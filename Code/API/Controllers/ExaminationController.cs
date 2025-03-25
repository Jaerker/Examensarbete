using AlfaCert.Models.ExaminationModels.Applicant;
using AlfaCert.Models.ExaminationModels;
using AlfaCert.Repository.Data;
using AlfaCert.Service.Services;
using AlfaCert.Shared.Library;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Playwright;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using AlfaCert.Models.UserModels.User;
using AlfaCert.Shared.DTO.Examination;
using AlfaCert.Shared.DTO.Examination.Applicant;
using AlfaCert.Models.CertificateModels;

//KOD FÖR EXAMENSARBETE

namespace AlfaCert.WebAPI.Controllers.Invigilator
{
    [ApiController]
    [Route("api/invigilators/examinations")]
    [Authorize(Roles = "Invigilator")]
    public class ExaminationController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly ExaminationRenderingService _renderService;

        public ExaminationController(IMapper mapper, DataContext context, ExaminationRenderingService renderService)
        {
            _mapper = mapper;
            _context = context;
            _renderService = renderService;
        }
        //Kod review

        [HttpGet("")]
        public async Task<IActionResult> GetExaminations([FromQuery] EnumState state = EnumState.Active)
        {
            var user = HttpContext.Items["User"] as UserModel;

            var examinations = await _context.Examinations
                                                .Where(e => user.Invigilators.Contains(e.Invigilator))
                                                .Include(e => e.Invigilator)
                                                .Include(e => e.ExaminationTemplate).ToListAsync();
            if (examinations == null) return NotFound();


            return Ok(JsonSerializer.Serialize(examinations.Select(_mapper.Map<ExaminationDto>).ToList()));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetExamination(string id, [FromQuery] EnumState state = EnumState.Active)
        {
            var user = HttpContext.Items["User"] as UserModel;
            if (!Guid.TryParse(id, out var _id)) return BadRequest($"Felaktigt ExaminationsID.");

            var examination = await _context.Examinations
                                                .Where(e => e.Id == _id && e.BaseState == state)
                                                .Include(e => e.ApplicantQuestions)
                                                    .ThenInclude(e => e.ApplicantAlternatives)
                                                        .ThenInclude(e => e.Alternative)
                                                .Include(e => e.ExaminationTemplate).FirstOrDefaultAsync();
            if (examination == null) return NotFound();


            return Ok(JsonSerializer.Serialize(_mapper.Map<ExaminationDto>(examination)));
        }
        [HttpPost("")]
        public async Task<IActionResult> SubmitOfflineExamination([FromBody] ExaminationDto examination)
        {
            var user = HttpContext.Items["User"] as UserModel;


            return Ok(JsonSerializer.Serialize(_mapper.Map<ExaminationDto>(examination)));
        }

        [HttpPost("applicant")]
        public async Task<IActionResult> TryToCreateApplicant([FromBody] ApplicantDto applicant)
        {
            var user = HttpContext.Items["User"] as UserModel;

            var certificant = await _context.Certificants.Where(c => c.NationalIdNumber == applicant.Certificant.NationalIdNumber).FirstOrDefaultAsync();

            var newApplicant = _mapper.Map<ApplicantModel>(applicant);

            if(certificant != null)
            {
                newApplicant.Certificant = null;
                newApplicant.CertificantId = certificant.Id;
            }

            await _context.Applicants.AddAsync(newApplicant);
            await _context.SaveChangesAsync();
            newApplicant.Certificant = certificant;

            return Ok(JsonSerializer.Serialize(_mapper.Map<ApplicantDto>(newApplicant)));
        }


        [HttpGet("create/{id}")]
        public async Task<IActionResult> CreateOfflineExamination(string id, [FromQuery] int amount = 1, [FromQuery] string companyId = "")
        {
            var user = HttpContext.Items["User"] as UserModel;
            if (!Guid.TryParse(id, out var _id)) return BadRequest($"Felaktigt Examinationsmall ID.");
            if(!Guid.TryParse(companyId, out var _companyId)) return BadRequest($"Felaktigt företags ID.");

            var invigilator = await _context.Invigilators.Where(i => i.CompanyId == _companyId && i.UserId == user.Id).Include(i => i.Company).FirstOrDefaultAsync();
            
            if (invigilator == null) return BadRequest("Något fel med Invigilator och Company ID");

            var examinationTemplate = await _context.ExaminationTemplates.Where(x => x.Id == _id && x.BaseState == EnumState.Active)
                                                                            .Include(x => x.ExaminationBlock)
                                                                                .ThenInclude(y => y.Sector)
                                                                            .Include(x => x.QuestionCategories)
                                                                                .ThenInclude(y => y.QuestionCategoryTemplate)
                                                                                    .ThenInclude(z => z.Questions)
                                                                                        .ThenInclude(c => c.Alternatives).FirstOrDefaultAsync();
            if (examinationTemplate == null) return BadRequest("Examination template not found.");
            List<ExaminationModel> examinations = new(); 
            for(int ex = 0; ex < amount; ex++)
            {
                var examination = new ExaminationModel
                {
                    BaseState = EnumState.Created,
                    CreatedAt = DateTime.Now,
                    CreatedById = user.Id,
                    InvigilatorId = invigilator.Id,
                    ExaminationTemplateId = examinationTemplate.Id,
                    InvigilatorCompanyName = invigilator.Company.Name,
                    InvigilatorName = $"{user.FirstName} {user.LastName}",
                    ApplicantQuestions = new List<ApplicantQuestionModel>(),
                    QuestionCategoryScores = new List<QuestionCategoryScoreModel>(),
                    HasStarted = false,
                    ExpiresAt = DateTime.Now.AddMonths(3)
                };

                foreach (var category in examinationTemplate.QuestionCategories.Where(x => x.BaseState == EnumState.Active))
                {
                    var questions = category.QuestionCategoryTemplate?.Questions.Where(x => x.BaseState == EnumState.Active).OrderBy(_ => Guid.NewGuid()).ToList();

                    for (int i = 0; i < category.AmountOfQuestions; i++)
                    {

                        var correctAlternatives = questions[i].Alternatives?.Where(x => x.IsCorrect && x.BaseState == EnumState.Active).OrderBy(_ => Guid.NewGuid()).ToList();
                        var incorrectAlternatives = questions[i].Alternatives?.Where(x => !x.IsCorrect && x.BaseState == EnumState.Active).OrderBy(_ => Guid.NewGuid()).ToList();

                        var applicantQuestion = new ApplicantQuestionModel
                        {
                            CreatedById = invigilator.Id,
                            CreatedAt = DateTime.Now,
                            ExaminationId = examination.Id,
                            QuestionId = questions[i].Id,
                            ApplicantAlternatives = new List<ApplicantAlternativeModel>()
                        };

                        for (int j = 0; j < questions[i].AmountOfCorrectAnswers; j++)
                        {
                            applicantQuestion.ApplicantAlternatives.Add(new ApplicantAlternativeModel
                            {
                                CreatedById = invigilator.Id,
                                CreatedAt = DateTime.Now,
                                ApplicantQuestionId = applicantQuestion.Id,
                                AlternativeId = correctAlternatives[j].Id
                            });

                        }
                        for (int j = 0; j < questions[i].AmountOfAlternativesToChooseBetween - questions[i].AmountOfCorrectAnswers; j++)
                        {
                            applicantQuestion.ApplicantAlternatives.Add(new ApplicantAlternativeModel
                            {
                                CreatedById = invigilator.Id,
                                CreatedAt = DateTime.Now,
                                ApplicantQuestionId = applicantQuestion.Id,
                                AlternativeId = incorrectAlternatives[j].Id
                            });
                        }
                        applicantQuestion.ApplicantAlternatives = applicantQuestion.ApplicantAlternatives.OrderBy(_ => Guid.NewGuid()).ToList();
                        examination.ApplicantQuestions.Add(applicantQuestion);
                    }
                }
                examinations.Add(examination);
            }

            
            await _context.AddRangeAsync(examinations);
            await _context.SaveChangesAsync();

            foreach (var exam in examinations)
                exam.Invigilator = invigilator;
            var html = await _renderService.GenerateOfflineExaminationPdf(examinations);

            //System.IO.File.WriteAllBytes("test.pdf", html);
            return Ok(JsonSerializer.Serialize(html));
        }

    }
}

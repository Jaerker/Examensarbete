using AlfaCert.Shared.DTO.Examination.Applicant;
using AlfaCert.Shared.DTO.Users;
using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO.Examination
{
    public class ExaminationDto
    {
        public Guid Id { get; set; }
        public Guid? InvigilatorId { get; set; } // Instruktörens ID
        public InvigilatorDtoForExamination? Invigilator { get; set; } // Instruktören
        public Guid? ExaminationTemplateId { get; set; }
        public ExaminationTemplateDtoForExamination? ExaminationTemplate { get; set; }
        public Guid ApplicantId { get; set; }
        public Guid? CertificateId { get; set; }
        public bool HasStarted { get; set; }
        public bool HasSubmitted { get; set; }
        public bool HasPassed { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime EndedAt { get; set; }
        public DateTime Deadline { get; set; }
        public IEnumerable<ApplicantQuestionDto>? ApplicantQuestions { get; set; }
        public IEnumerable<QuestionCategoryScoreDto>? QuestionCategoryScores { get; set; }
        public string? InvigilatorCompanyName { get; set; }
        public string? InvigilatorName { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class ExaminationDtoForApplicant
    {
        public Guid Id { get; set; }
        public Guid InvigilatorId { get; set; } // Utbildarens ID
        public Guid ApplicantId { get; set; }
        public Guid ExaminationTemplateId { get; set; }
        public bool HasStarted { get; set; }
        public bool HasSubmitted { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime EndedAt { get; set; }
        public DateTime Deadline { get; set; }
        public IEnumerable<ApplicantQuestionDto>? ApplicantQuestions { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;

    }

    public class QuestionCategoryScoreDto
    {
        public QuestionCategoryDto QuestionCategory { get; set; }
        public int Score { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }

}

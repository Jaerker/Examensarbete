using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO.Examination.Applicant
{
    public class ApplicantQuestionDto
    {
        public Guid Id { get; set; }
        public Guid ExaminationId { get; set; }
        public QuestionDtoForApplicant Question { get; set; }
        public IEnumerable<ApplicantAlternativeDto>? ApplicantAlternatives { get; set; }
        public bool HasLeftRemark { get; set; } = false;
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
}

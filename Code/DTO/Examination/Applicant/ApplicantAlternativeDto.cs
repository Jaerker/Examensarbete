using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO.Examination.Applicant
{
    public class ApplicantAlternativeDto
    {
        public Guid Id { get; set; }
        public Guid? ApplicantQuestionId { get; set; }
        public AlternativeDtoForApplicant? Alternative { get; set; }
        public bool IsChosen { get; set; } = false;
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class ApplicantAlternativeUpdateDto
    {
        public Guid Id { get; set; }
        public bool IsChosen { get; set; }
    }
}

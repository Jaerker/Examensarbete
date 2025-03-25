using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO.Examination
{
    public class AlternativeDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid QuestionId { get; set; }
        public string? Content { get; set; }
        public bool IsCorrect { get; set; } = false;
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class AlternativeDtoForApplicant
    {
        public Guid? Id { get; set; }
        public string? Content { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }

}

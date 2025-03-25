using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO.Examination
{
    public class QuestionDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid QuestionCategoryTemplateId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? ReferenceContent { get; set; }
        public bool HasMultipleCorrectAnswers { get; set; } = false;
        public int AmountOfCorrectAnswers { get; set; } = 1;
        public int AmountOfAlternativesToChooseBetween { get; set; } = 4;
        public IEnumerable<AlternativeDto>? Alternatives { get; set; }
        public IEnumerable<RemarkDto>? Remarks { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public bool IsPublic { get; set; } = true;
        public EnumState BaseState { get; set; } = EnumState.Active;

    }

    public class QuestionDtoForApplicant
    {
        public Guid? Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? ReferenceContent { get; set; }
        public bool HasMultipleCorrectAnswers { get; set; }
        public int AmountOfCorrectAnswers { get; set; }
        public int AmountOfAlternativesToChooseBetween { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
}

using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO.Examination
{
    public class QuestionCategoryTemplateDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Guid? SectorId { get; set; }
        public Guid QuestionCategoryBlockId { get; set; }
        public QuestionCategoryBlockDtoForQuestionCategoryTemplate? QuestionCategoryBlock { get; set; }
        public IEnumerable<QuestionDto>? Questions { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
}

using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO.Examination
{
    public class QuestionCategoryBlockDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = null!;
        public Guid? SectorId { get; set; }
        public Guid ExaminationTemplateId { get; set; }
        public IEnumerable<QuestionCategoryTemplateDto>? QuestionCategoryTemplates { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }

    public class QuestionCategoryBlockDtoForQuestionCategoryTemplate
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = null!;
        public Guid ExaminationTemplateId { get; set; }
        public Guid? SectorId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
}

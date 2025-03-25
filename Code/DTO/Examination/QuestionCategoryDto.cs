using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO.Examination
{
    public class QuestionCategoryDto
    {
        public Guid ExaminationTemplateId { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
        public QuestionCategoryTemplateDto? QuestionCategoryTemplate { get; set; }
        public ExaminationTemplateDtoForQuestionCategory ExaminationTemplate { get; set; }
        public Guid QuestionCategoryTemplateId { get; set; }
        public int AmountOfQuestions { get; set; }
        public int AmountOfAnswersToPass { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }

}

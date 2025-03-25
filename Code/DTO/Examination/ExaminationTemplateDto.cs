using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO.Examination
{
    public class ExaminationTemplateDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? CertificateTitle { get; set; }
        public string? CertificateDescription { get; set; }
        public int CertificatePeriodOfValidityInMonths { get; set; }
        public Guid? ExaminationBlockId { get; set; }
        public ExaminationBlockForExaminationTemplateDto? ExaminationBlock { get; set; }
        public Guid? SectorId { get; set; }
        public int TimeLimitInMinutes { get; set; }
        public IEnumerable<QuestionCategoryBlockDto>? QuestionCategoryBlocks { get; set; }
        public IEnumerable<QuestionCategoryDto>? QuestionCategories { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public bool IsPublic { get; set; } = true;
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class ExaminationTemplateDtoForLobby
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string CertificateTitle { get; set; } = null!;
        public string CertificateDescription { get; set; } = null!;
        public int CertificatePeriodOfValidityInMonths { get; set; }
        public Guid? ExaminationBlockId { get; set; }
        public Guid? SectorId { get; set; }
        public int TimeLimitInMinutes { get; set; }
        public IEnumerable<QuestionCategoryDto> QuestionCategories { get; set; }
        public IEnumerable<QuestionCategoryBlockDto> QuestionCategoryBlocks { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class ExaminationTemplateDtoForUpdatingForm
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string CertificateTitle { get; set; } = null!;
        public string CertificateDescription { get; set; } = null!;
        public int CertificatePeriodOfValidityInMonths { get; set; }
        public int TimeLimitInMinutes { get; set; }

        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class ExaminationTemplateDtoForQuestionCategory
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Title { get; set; }
        public Guid? SectorId { get; set; }
        public Guid? ExaminationBlockId { get; set; }
        public ExaminationBlockForExaminationTemplateDto? ExaminationBlock { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class ExaminationTemplateDtoForExamination
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public Guid? SectorId { get; set; }
        public Guid? ExaminationBlockId { get; set; }
        public ExaminationBlockForExaminationTemplateDto? ExaminationBlock { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
}

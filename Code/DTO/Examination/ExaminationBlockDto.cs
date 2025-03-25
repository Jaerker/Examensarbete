using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO.Examination
{
    public class ExaminationBlockDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Limitations { get; set; }
        public IEnumerable<ExaminationTemplateDto>? ExaminationTemplates { get; set; }
        public Guid SectorId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class ExaminationBlockDtoForLobby
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Limitations { get; set; }

        public IEnumerable<ExaminationTemplateDtoForLobby>? ExaminationTemplates { get; set; }
        public SectorDtoForNested Sector { get; set; }
        public Guid SectorId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class ExaminationBlockForExaminationTemplateDto
    {
        public Guid? Id { get; set; }
        public string? Title { get; set; }
        public Guid? SectorId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
}

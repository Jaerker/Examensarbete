using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO.Permissions
{
    public class SectorExaminationTemplatePermissionDto
    {
        public Guid? SectorId { get; set; }
        public SectorDto? Sector { get; set; }
        public Guid? ExaminationTemplateId { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }

}

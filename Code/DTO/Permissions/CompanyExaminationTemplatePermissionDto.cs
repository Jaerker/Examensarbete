using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO.Permissions
{
    public class CompanyExaminationTemplatePermissionDto
    {
        public Guid? CompanyId { get; set; }
        public CompanyDtoForInvigilatorAndCompanySupervisor? Company { get; set; }
        public Guid? ExaminationTemplateId { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }

}

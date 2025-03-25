using AlfaCert.Shared.DTO.Users;
using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO.Permissions
{
    public class InvigilatorExaminationTemplatePermissionDto
    {
        public Guid? InvigilatorId { get; set; }
        public InvigilatorDtoForPermission? Invigilator { get; set; }
        public Guid? ExaminationTemplateId { get; set; }
        public DateTime? ExpiresAt { get; set; }

        public EnumState BaseState { get; set; } = EnumState.Active;
    }


}
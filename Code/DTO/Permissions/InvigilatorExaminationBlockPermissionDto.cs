using AlfaCert.Shared.DTO.Examination;
using AlfaCert.Shared.DTO.Users;
using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO.Permissions
{
    public class InvigilatorExaminationBlockPermissionDto
    {
        public Guid? InvigilatorId { get; set; }
        public InvigilatorDtoForPermission? Invigilator { get; set; }
        public Guid? ExaminationBlockId { get; set; }
        public ExaminationBlockDto? ExaminationBlock { get; set; }
        public DateTime? ExpiresAt { get; set; }

        public EnumState BaseState { get; set; } = EnumState.Active;
    }


}
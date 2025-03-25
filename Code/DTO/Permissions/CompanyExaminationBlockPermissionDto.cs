using AlfaCert.Shared.DTO.Examination;
using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO
{
    public class CompanyExaminationBlockPermissionDto
    {
        public Guid? CompanyId { get; set; }
        public CompanyDtoForPermission? Company { get; set; }
        public Guid? ExaminationBlockId { get; set; }
        public ExaminationBlockDto? ExaminationBlock { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }

}

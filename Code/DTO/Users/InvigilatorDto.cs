using AlfaCert.Shared.DTO.Permissions;
using AlfaCert.Shared.Library;
using System.ComponentModel.DataAnnotations;

namespace AlfaCert.Shared.DTO.Users
{
    public class CreatingInvigilatorDto //Instruktör
    {
        [Required(ErrorMessage = "User ID is required.")] public Guid UserId { get; set; }
    }

    public class InvigilatorDto : IRoleDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public UserDto? User { get; set; }
        public Guid? UserId { get; set; }
        public CompanyDtoForInvigilatorAndCompanySupervisor? Company { get; set; }
        public Guid CompanyId { get; set; }
        public IEnumerable<InvigilatorExaminationBlockPermissionDto>? InvigilatorExaminationBlockPermissions { get; set; }
        public string? HubIdentifier { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class InvigilatorDtoForUser : IRoleDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid? UserId { get; set; }
        public CompanyDtoForInvigilatorAndCompanySupervisor? Company { get; set; }
        public Guid CompanyId { get; set; }
        public IEnumerable<InvigilatorExaminationBlockPermissionDto>? InvigilatorExaminationBlockPermissions { get; set; }
        public string? HubIdentifier { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class InvigilatorDtoForPermission
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public UserDtoForNested? User { get; set; }
        public Guid? UserId { get; set; }
        public CompanyDtoForInvigilatorAndCompanySupervisor? Company { get; set; }
        public Guid CompanyId { get; set; }
        public string? HubIdentifier { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class InvigilatorDtoForApplicant
    {
        public Guid Id { get; set; }
        public UserDtoForApplicant User { get; set; }
        public string? HubIdentifier { get; set; }
        public CompanyDto Company { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class InvigilatorDtoForExamination
    {
        public UserDtoForApplicant User { get; set; }
        public Guid CompanyId { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
}

using AlfaCert.Shared.Library;
using System.ComponentModel.DataAnnotations;

namespace AlfaCert.Shared.DTO.Users
{
    public class CreatingCompanySupervisorDto
    {
        [Required(ErrorMessage = "User ID is required.")] public Guid UserId { get; set; }
        [Required(ErrorMessage = "Company ID is required.")] public Guid CompanyId { get; set; }
        public string? CompanyRole { get; set; }
    }

    public class CompanySupervisorDto : IRoleDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public UserDto? User { get; set; }
        public Guid? SectorId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? CompanyId { get; set; }
        public CompanyDtoForInvigilatorAndCompanySupervisor Company { get; set; }
        public string? CompanyRole { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class CompanySupervisorDtoForUser : IRoleDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid? SectorId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? CompanyId { get; set; }
        public CompanyDtoForInvigilatorAndCompanySupervisor Company { get; set; }
        public string? CompanyRole { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }

}

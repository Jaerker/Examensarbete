using AlfaCert.Shared.Library;
using System.ComponentModel.DataAnnotations;

namespace AlfaCert.Shared.DTO.Users
{
    public class CreatingSectorSupervisorDto
    {
        [Required(ErrorMessage = "User ID is required.")] public Guid UserId { get; set; }
        [Required(ErrorMessage = "Sector ID is required.")] public Guid? SectorId { get; set; }
        public string? CompanyRole { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }

    public class SectorSupervisorDto : IRoleDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid? UserId { get; set; }
        public UserDto? User { get; set; }
        public Guid? SectorId { get; set; }
        public SectorDtoForNested? Sector { get; set; }
        public string? CompanyRole { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class SectorSupervisorDtoForUser : IRoleDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid? UserId { get; set; }
        public Guid? SectorId { get; set; }
        public SectorDtoForNested? Sector { get; set; }
        public string? CompanyRole { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
}

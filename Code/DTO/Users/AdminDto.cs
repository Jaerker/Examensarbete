using AlfaCert.Shared.Library;
using System.ComponentModel.DataAnnotations;

namespace AlfaCert.Shared.DTO.Users
{
    public class CreatingAdminDto
    {
        [Required(ErrorMessage = "User ID is required.")] public Guid UserId { get; set; }
        public string? CompanyRole { get; set; }
    }

    public class AdminDto : IRoleDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public UserDto? User { get; set; }
        public Guid? UserId { get; set; }
        public string? CompanyRole { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class AdminDtoForUser : IRoleDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid? UserId { get; set; }
        public string? CompanyRole { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
}

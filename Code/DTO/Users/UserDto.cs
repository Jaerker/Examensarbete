using AlfaCert.Shared.DTO.Examination.Applicant;
using AlfaCert.Shared.Library;
using System.ComponentModel.DataAnnotations;

namespace AlfaCert.Shared.DTO.Users
{

    public class CreatingUserDto
    {
        [Required(ErrorMessage = "Du måste fylla i ditt förnamn.")] public string? FirstName { get; set; }
        [Required(ErrorMessage = "Du måste fylla i ditt efternamn.")] public string? LastName { get; set; }
        [Required(ErrorMessage = "Du måste fylla i din mailadress.")] public string? Email { get; set; }
        [Required(ErrorMessage = "Du måste fylla i ditt person nummer.")] public string? SocialSecurityNumber { get; set; }
        [Required(ErrorMessage = "Du måste fylla i ett lösenord.")] public string? Password { get; set; }
        [Compare("Password", ErrorMessage = "Lösenorden måste matcha.")] public string? ConfirmPassword { get; set; }
        public string? CompanyRole { get; set; }

    }

    public class UserDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? SocialSecurityNumber { get; set; } = null;
        public Guid? AdminId { get; set; }
        public AdminDtoForUser? Admin { get; set; }
        public IEnumerable<InvigilatorDtoForUser>? Invigilators { get; set; }
        public IEnumerable<CompanySupervisorDtoForUser>? CompanySupervisors { get; set; }
        public IEnumerable<SectorSupervisorDtoForUser>? SectorSupervisors { get; set; }
        public Guid? CertificantId { get; set; }
        public CertificantDto? Certificant { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public List<Role>? Roles { get; set; } = new();
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class UserDtoForNested
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? SocialSecurityNumber { get; set; } = null;
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class UserDtoForApplicant
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class UserDtoForJwt
    {
        public Guid Id { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class UserDtoForUpdatingPassword
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Password is required.")] public string? Password { get; set; }

        [Required(ErrorMessage = "Password is required.")] public string? NewPassword { get; set; }
        [Compare("NewPassword", ErrorMessage = "The password and confirmation password do not match.")] public string? ConfirmNewPassword { get; set; }

        public EnumState BaseState { get; set; } = EnumState.Active;
    }

    public class UserUpdateDto
    {
        public Guid? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? SocialSecurityNumber { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }

    public class UserRoleDto
    {
        public Guid Id { get; set; }
        public UserDto User { get; set; }
        public RoleDto Role { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
}

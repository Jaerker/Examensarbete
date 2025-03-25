using AlfaCert.Shared.DTO.Users;
using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO
{
    public class CompanyDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string OrganizationNr { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Description { get; set; }
        public string? StreetNameAndNumber { get; set; }
        public string? ZipCode { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; } = "Sverige";
        public string? Tag { get; set; } = "def";
        public IEnumerable<CompanySupervisorDto>? CompanySupervisors { get; set; }
        public IEnumerable<CompanyExaminationBlockPermissionDto>? CompanyExaminationBlockPermissions { get; set; }
        public IEnumerable<InvigilatorDto>? Invigilators { get; set; }
        public SectorDtoForNested? Sector { get; set; }
        public Guid? SectorId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class CompanyDtoForApplicant
    {
        public string Name { get; set; } = null!;
        public string OrganizationNr { get; set; } = null!;
        public EnumState BaseState { get; set; } = EnumState.Active;

    }
    public class CompanyDtoForSector
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? OrganizationNr { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? StreetNameAndNumber { get; set; }
        public string? ZipCode { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? Tag { get; set; }
        public Guid? SectorId { get; set; }
        public IEnumerable<CompanyExaminationBlockPermissionDto>? CompanyExaminationBlockPermissions { get; set; }
        public IEnumerable<CompanySupervisorDto>? CompanySupervisors { get; set; }
        public IEnumerable<InvigilatorDto>? Invigilators { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class CompanyDtoForInvigilatorAndCompanySupervisor
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? OrganizationNr { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? StreetNameAndNumber { get; set; }
        public string? ZipCode { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? Tag { get; set; }
        public SectorDtoForNested? Sector { get; set; }
        public Guid? SectorId { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class CompanyDtoForPermission
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? OrganizationNr { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? StreetNameAndNumber { get; set; }
        public string? ZipCode { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? Tag { get; set; }
        public SectorDtoForNested? Sector { get; set; }
        public Guid? SectorId { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
    public class CompanyUpdateDto
    {
        public string? Name { get; set; }
        public string? OrganizationNr { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? StreetNameAndNumber { get; set; }
        public string? ZipCode { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? Tag { get; set; }
        public Guid? SectorId { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }

}

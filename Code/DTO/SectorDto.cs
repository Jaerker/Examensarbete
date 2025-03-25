using AlfaCert.Shared.DTO.Examination;
using AlfaCert.Shared.DTO.Users;
using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO
{
    public class SectorDtoRoot
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? OrganizationNr { get; set; }
        public string? Description { get; set; }
        public string? StreetNameAndNumber { get; set; }
        public string? ZipCode { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; } = "Sverige";
        public string? Tag { get; set; } = "def";
        public string? IconUrl { get; set; }
        public string? ImageUrl { get; set; }
        public string? StyleUrl { get; set; }
        public DateTime AuthorizationExpiredAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }

    public class SectorDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? OrganizationNr { get; set; }
        public string? Description { get; set; }
        public string? StreetNameAndNumber { get; set; }
        public string? ZipCode { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; } = "Sverige";
        public string? IconUrl { get; set; }
        public string? ImageUrl { get; set; }
        public string? StyleUrl { get; set; }
        public string? Tag { get; set; } = "def";
        public IEnumerable<CompanyDto>? Companies { get; set; }
        public IEnumerable<SectorSupervisorDto>? SectorSupervisors { get; set; }
        public IEnumerable<ExaminationBlockDto>? ExaminationBlocks { get; set; }
        public IEnumerable<QuestionCategoryBlockDto>? QuestionCategoryBlocks { get; set; }
        public DateTime? AuthorizationExpiredAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }

    public class SectorDtoForNested
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string OrganizationNr { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string StreetNameAndNumber { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string? IconUrl { get; set; }
        public string? ImageUrl { get; set; }
        public string? StyleUrl { get; set; }
        public string? Tag { get; set; } = "def";
        public ICollection<ExaminationBlockDto>? ExaminationBlocks { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }

    public class SectorUpdateDto
    {
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? OrganizationNr { get; set; }
        public string? Description { get; set; }
        public string? StreetNameAndNumber { get; set; }
        public string? ZipCode { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? Tag { get; set; } = "def";
        public string? IconUrl { get; set; }
        public string? ImageUrl { get; set; }
        public string? StyleUrl { get; set; }
        public DateTime? AuthorizationExpiredAt { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
}

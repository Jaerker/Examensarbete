using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO.Examination.Applicant
{
    public class CertificantDto
    {
        public Guid? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? NationalIdNumber { get; set; }
        public DateOnly? DateOfBirth { get; set; } = DateOnly.MinValue;
        public IEnumerable<CertificateDto>? Certificates { get; set; }
        public IEnumerable<ApplicantDto>? Applicants { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }

    public class CertificantDtoForNested
    {
        public Guid? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public IEnumerable<CertificateDtoForCertificant>? Certificates { get; set; }
        public string? NationalIdNumber { get; set; }
        public DateOnly? DateOfBirth { get; set; }
    }
}

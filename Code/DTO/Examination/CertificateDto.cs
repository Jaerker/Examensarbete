using AlfaCert.Shared.DTO.Examination.Applicant;
using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO.Examination
{
    public class CertificateDto
    {
        public Guid Id { get; set; }
        public Guid? CertificantId { get; set; }
        public CertificantDtoForNested? Certificant { get; set; }
        public Guid? ExaminationBlockId { get; set; }
        public ExaminationBlockDto? ExaminationBlock { get; set; }
        public IEnumerable<ExaminationDto>? Examinations { get; set; }
        public bool HasViolatedCertificate { get; set; } = false;
        public string? ReasonForViolation { get; set; }
        public string? CertificantCompanyName { get; set; }
        public string? InvigilatorCompanyName { get; set; }
        public string? InvigilatorName { get; set; }
        public DateTime? CertificateViolatedAt { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime? ExpiresAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }

    public class CertificateDtoForCertificant
    {
        public Guid Id { get; set; }
        public Guid? ExaminationBlockId { get; set; }
        public ExaminationBlockDto? ExaminationBlock { get; set; }
        public IEnumerable<ExaminationDto>? Examinations { get; set; }
        public bool HasViolatedCertificate { get; set; } = false;
        public string? ReasonForViolation { get; set; }
        public string? CertificantCompanyName { get; set; }
        public string? InvigilatorCompanyName { get; set; }
        public string? InvigilatorName { get; set; }
        public DateTime? CertificateViolatedAt { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime? ExpiresAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }

}
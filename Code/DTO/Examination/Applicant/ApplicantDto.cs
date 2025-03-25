using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO.Examination.Applicant
{
    public class CreatingApplicantDto
    {
        public CertificantDto Certificant { get; set; } = new();
        public string? CompanyName { get; set; }
    }
    public class ApplicantDto
    {
        public Guid Id { get; set; }
        public Guid? CertificantId { get; set; }
        public CertificantDtoForNested? Certificant { get; set; }
        public string? CompanyName { get; set; }
        public LobbyDtoForApplicant? Lobby { get; set; }
        public Guid? LobbyId { get; set; }
        public bool AskedToUpdate { get; set; }
        public bool InformationHasBeenVerified { get; set; }
        public bool IsQualifiedToTakeExamination { get; set; }
        public bool HasBeenDismissed { get; set; }
        public bool HasBeenUpdated { get; set; }
        public ApplicantState State { get; set; } = ApplicantState.Active;
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }

    public class ApplicantUpdateDto
    {
        public Guid Id { get; set; }
        public Guid? CertificantId { get; set; }
        public CertificantDto? Certificant { get; set; }
        public Guid? LobbyId { get; set; }
        public string? CompanyName { get; set; }
        public bool? AskedToUpdate { get; set; }
        public bool? InformationHasBeenVerified { get; set; }
        public bool? IsQualifiedToTakeExamination { get; set; }
        public bool? HasBeenDismissed { get; set; }
        public bool? HasBeenUpdated { get; set; }
        public string? HubIdentifier { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
        public ApplicantState State { get; set; } = ApplicantState.Active;
    }
}

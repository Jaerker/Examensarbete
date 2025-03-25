using AlfaCert.Shared.DTO.Examination.Applicant;
using AlfaCert.Shared.DTO.Users;
using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO.Examination
{
    public class CreatingLobbyDto
    {
        public ExaminationBlockDto ExaminationBlock { get; set; }
        public Guid InvigilatorId { get; set; }
    }

    public class LobbyDto
    {
        public Guid Id { get; set; }
        public Guid InvigilatorId { get; set; }
        public IEnumerable<ApplicantDto> Applicants { get; set; }
        public ExaminationBlockDto ExaminationBlock { get; set; }
        public bool IsOpen { get; set; }
        public bool HasStarted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }

    public class LobbyDtoForApplicant
    {
        public Guid Id { get; set; }
        public InvigilatorDtoForApplicant Invigilator { get; set; }
        public Guid InvigilatorId { get; set; }
        public ExaminationBlockDtoForLobby ExaminationBlock { get; set; }
        public bool IsOpen { get; set; }
        public bool HasStarted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? SectorTag { get; set; }
        public EnumState BaseState { get; set; } = EnumState.Active;
    }
}

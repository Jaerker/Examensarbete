namespace AlfaCert.Shared.DTO.Examination
{
    public class RemarkDto
    {
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        public string Content { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
    }

    public class RemarkUpdateDto
    {
        public Guid Id { get; set; }
        public string? Content { get; set; }
    }

}

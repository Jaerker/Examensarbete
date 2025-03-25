namespace AlfaCert.Shared.DTO.Users
{
    public interface IRoleDto
    {
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }
    }
}

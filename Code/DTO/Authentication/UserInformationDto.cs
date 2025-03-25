using AlfaCert.Shared.DTO.Users;
using AlfaCert.Shared.Library;

namespace AlfaCert.Shared.DTO.Authentication
{
    public class UserInformationDto
    {
        public UserDto User { get; set; }
        public List<Role>? Roles { get; set; } = new();
    }
}

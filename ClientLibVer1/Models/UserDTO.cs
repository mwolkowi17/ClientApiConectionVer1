using ClientLib.Services;

namespace ClientLib.Models
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserStatus UserStatus { get; set; }
        public UserRole UserRole { get; set; }
    }
}

using ClientLibVer1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientLibVer1.Models
{
    public class UserB
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserStatus UserStatus { get; set; }
        public UserRole UserRole { get; set; }
    }
}

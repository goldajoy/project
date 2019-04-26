using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.PostModel
{
    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string DeviceToken { get; set; }
        public ClassLibrary.Enum.UserRole UserRole { get; set; }
        public int DeviceType { get; set; }
    }
}

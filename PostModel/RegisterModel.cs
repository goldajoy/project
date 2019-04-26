using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.PostModel
{
    public class RegisterModel
    {
        public ClassLibrary.Enum.ProfileType ProfileType { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string DeviceToken { get; set; }
        public ClassLibrary.Enum.UserRole UserRole { get; set; }
        public string ProfilePic { get; set; }
        public string UserLat { get; set; }
        public string UserLong { get; set; }
        public int DeviceType { get; set; }


    }
}

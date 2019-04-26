using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.MapModel
{
    public class UserViewModel
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public Nullable<System.Guid> Guid { get; set; }
        public string ProfileType { get; set; }
        public string UserRole { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }   
        public string JobReminder { get; set; }
        public string State { get; set; }
        public string PushStatusstring { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Rating { get; set; }
        //public bool IsBoth { get; set; }
        //public Nullable<bool> IsActive { get; set; }
        public string ProfilePic { get; set; }
        public bool IsAdmin { get; set; }
        public List<UserPropertyViewModel> UserProperties { get; set; }
        //public List<UserJobViewModel> JobList { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.PostModel
{
    public class EditUserPropertyModel
    {
        public ClassLibrary.Enum.JobType JobType { get; set; }
        public string PropertyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public ClassLibrary.Enum.PropertyType PropertyType { get; set; }
        public string BedroomNum { get; set; }
        public string BathroomNum { get; set; }
        public string Description { get; set; }
        //public string DeviceToken { get; set; }
        public List<string> PropertyImages { get; set; }
        public string UserId { get; set; }
        public string PropertyId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}

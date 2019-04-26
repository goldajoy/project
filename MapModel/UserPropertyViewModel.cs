using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.MapModel
{
    public class UserPropertyViewModel
    {
        public long Id { get; set; }
        public string PropertyId { get; set; }
        public string PropertyName { get; set; }
        public string UserId { get; set; }
        public Nullable<System.Guid> PropertyGuid { get; set; }
        public int JobTypeId { get; set; }
        public string JobType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int PropertyTypeId { get; set; }
        public string PropertyType { get; set; }
        public string BedroomNumString { get; set; }
        public string BathroomNumString { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public List<string> PropertyImages { get; set; }
    }
}

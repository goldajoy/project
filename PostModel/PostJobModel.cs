using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.PostModel
{
    public class PostJobModel
    {
        public string PropertyId { get; set; }
        public string UserId { get; set; }
        public string CleanerId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Price { get; set; }
        //public ClassLibrary.Enum.JobStatus JobStatus { get; set; }
        public string Token { get; set; }
        public string Instructions { get; set; }
        public ClassLibrary.Enum.WorkType WorkType { get; set; }
        public string IsNewProperty { get; set; }
        public AddUserPropertyModel Property { get; set; }
    }
}

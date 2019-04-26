using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.PostModel
{
    public class FetchUserJobModel
    {
        public string UserId { get; set; }
        public string Index { get; set; }
        public ClassLibrary.Enum.JobStatus JobStatus { get; set; }

        public string startDate { get; set; }
        public string endDate { get; set; }
        public long propertyId { get; set; }
        public ClassLibrary.Enum.WorkType workType { get; set; }

    }
}

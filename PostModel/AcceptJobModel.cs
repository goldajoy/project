using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.PostModel
{
    public class AcceptJobModel
    {
        public string CleanerId { get; set; }
        public string UserId { get; set; }
        public string CounterOfferId { get; set; }
        public string IsCounterOffer { get; set; }
        public string JobId { get; set; }
        public ClassLibrary.Enum.JobStatus JobStatus { get; set; }
    }
}

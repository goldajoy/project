using ClassLibrary.PostModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.MapModel
{
    public class AdminCleanerJobsMapModel
    {
        //public long JobId { get; set; }
        //public long UserId { get; set; }
        //public long PropertyId { get; set; }
        //public string JobIdString { get; set; }
        //public string UserIdString { get; set; }
        //public string PropertyIdString { get; set; }
        //public string DateString { get; set; }
        //public string TimeString { get; set; }
        //public string PriceString { get; set; }
        //public string WorkType { get; set; }
        //public string Instructions { get; set; }
        //public int JobStatusId { get; set; }
        //public string JobStatus { get; set; }
        //public string IsFeedbackGiven { get; set; }
        //public string CleanerComment { get; set; }
        public UserPropertyViewModel PropertyDetail { get; set; }
        public List<CustomDataClass> ChecklistData { get; set; }
        public List<CounterOfferMapModel> CounterOffers { get; set; }
        public UserViewModel AcceptedCleanerDetail { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.PostModel
{
    public class CleanerJobListModel
    {
        public string CleanerId { get; set; }
        public string Index { get; set; }
        public ClassLibrary.Enum.JobStatus JobStatus { get; set; }
        public string Price { get; set; }
        public string Date { get; set; }
    }
    public class CleanerJobListModelModified
    {
        public string CleanerId { get; set; }
        public string Index { get; set; }
        public ClassLibrary.Enum.JobStatus JobStatus { get; set; }
        public string Price { get; set; }
        public string Timezone { get; set; }
        public string Date { get; set; }
    }
   
}

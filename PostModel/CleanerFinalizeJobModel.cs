using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.PostModel
{
    public class CleanerFinalizeJobModel
    {
        public string CleanerId { get; set; }
        public string JobId { get; set; }
        public string Comment { get; set; }
        public string IsFinalized { get; set; }
        public List<DataClassValues> Values { get; set; }
    }
}

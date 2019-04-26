using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.MapModel
{
    public class FeedbackMapModel
    {
        public long JobId { get; set; }
        public string JobIdstring { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public string Ratingstring { get; set; }
    }
}

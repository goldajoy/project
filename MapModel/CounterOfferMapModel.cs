using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.MapModel
{
    public class CounterOfferMapModel
    {
        public string CounterOfferIdstring { get; set; }
        public string CleanerIdstring { get; set; }
        public string JobIdstring { get; set; }
        public string Pricestring { get; set; }
        public string IsAcceptedstring { get; set; }
        public UserViewModel CleanerDetails { get; set; }
    }
}

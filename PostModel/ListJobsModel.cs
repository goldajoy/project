using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.PostModel
{
    public class ListJobsModel
    {
        public string CleanerId { get; set; }
        public string PriceFilter { get; set; }
        public string DistanceFilter { get; set; }
        public ClassLibrary.Enum.PropertyType PropertyTypeFilter { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        public string Index { get; set; }
    }

    public class ListJobsModelDay
    {
        public string CleanerId { get; set; }
        public string PriceFilter { get; set; }
        public string DistanceFilter { get; set; }
        public ClassLibrary.Enum.PropertyType PropertyTypeFilter { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        public string Index { get; set; }
        public string today { get; set; }
    }

}

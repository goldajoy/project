using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.PostModel
{
    public class EditUserJobModel
    {
        public string JobId { get; set; }
        public string PropertyId { get; set; }
        public string CurrentCleanerId { get; set; }
        public string NextCleanerId { get; set; }
        public bool hasMadeAnyChange { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string IsEditedProperty { get; set; }
        public string Instructions { get; set; }
        public ClassLibrary.Enum.WorkType WorkType { get; set; }
        public string IsNewProperty { get; set; }
        public EditUserPropertyModel Property { get; set; }
    }
}

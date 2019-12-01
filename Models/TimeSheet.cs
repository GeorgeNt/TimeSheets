using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheets.Models
{
    public class TimeSheet
    {
        public DateTime dateCreated { get; set; }
        public DateTime dateUpdated { get; set; }
        public int hoursOfWork { get; set; }
        public Project Project { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheets.Models
{
    public class TimeSheetProject
    {
        //public TimeSheet TimeSheet { get; set; }
        public int TimeSheetId { get; set; }
        public int ProjectId { get; set; }
        public IEnumerable<TimeSheet> TimeSheets { get; set; }
        public Project Project { get; set; }
    }
}

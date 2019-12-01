using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheets.Models
{
    public class TimeSheet
    {
        private DateTime date { get; set; }
        private int hoursOfWork { get; set; }
        private Project project { get; set; }

    }
}

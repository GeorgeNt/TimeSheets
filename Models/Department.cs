using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheets.Models
{
    public class Department
    {
        private String Name { get; set; }
        private Department Head { get; set; }
    }
}

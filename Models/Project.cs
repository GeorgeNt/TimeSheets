using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheets.Models
{
    public class Project
    {
        public String Name { get; set; }
        public List<Department> RelatedDepartments { get; set; }
        public Department Department { get; set; }
        public IEnumerable<TimeSheet> TimeSheets { get; set; }
    }
}

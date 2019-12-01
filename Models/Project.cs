using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheets.Models
{
    public class Project
    {
        private String Name { get; set; }
        private List<Department> RelatedDepartments { get; set; }

        private Department Department { get; set; }
    }
}

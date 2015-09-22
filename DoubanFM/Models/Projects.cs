using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Models
{
    public class Project
    {
        public string Name { get; set; }

        public string Code { get; set; }
    }
    public class Projects
    {
        public List<Project> ProjectList { get; set; }
    }
}

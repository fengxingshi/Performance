using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace Performance.Models
{
    public class Project
    {
        public string PName { get; set; }

        public string PCode { get; set; }

        public string PColor { get; set; }
    }
    public class Projects
    {
        public List<Project> ProjectList { get; set; }
    }
}

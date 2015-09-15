using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.APIs
{
    public class WebAPI
    {
        //string url = "http://localhost:42535/api/";

        public static string GetDept(string orgId)
        {
            return "http://localhost:42535/api/DeptController/"+orgId;
        }

        public static string GetPorgress(string orgId,long deptId)
        {
            return "http://localhost:42535/api/Query/Progress/" + orgId+"/"+deptId;
        }
    }
}

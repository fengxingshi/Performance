using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.APIs
{
    public class WebAPI
    {
        private readonly static string url = "http://localhost:42535/api/";

        public static string GetDept(string orgId)
        {
            return url + "/DeptController/" + orgId;
        }

        public static string GetPorgress(string orgId,long deptId)
        {
            return  url + "/Query/Progress/" + orgId+"/"+deptId;
        }

        public static string GetMenus(string ssxt)
        {
            return url + "/Query/Menus/" + ssxt;
        }

    }
}

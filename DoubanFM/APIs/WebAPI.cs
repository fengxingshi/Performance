using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.APIs
{
    public class WebAPI
    {
        //string url = "http://localhost:42535";
        public static string GetChannels()
        { return "http://www.douban.com/j/app/radio/channels";
        }
        public static string GetPlayList(string channel)
        {
            return "http://douban.fm/j/mine/playlist?channel=" + channel;
        }
        public static string GetDept(string orgId)
        {
            return "http://localhost:42535/api/DeptController/"+orgId;
        }
    }
}

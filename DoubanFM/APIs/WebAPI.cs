using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubanFM.APIs
{
    public class WebAPI
    {
        public static string GetChannels()
        { return "http://www.douban.com/j/app/radio/channels";
        }
        public static string GetPlayList(string channel)
        {
            return "http://douban.fm/j/mine/playlist?channel=" + channel;
        }
    }
}

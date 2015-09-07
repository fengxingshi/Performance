using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoubanFM.Models;
using DoubanFM.APIs;

namespace DoubanFM.Services
{
    public class PlayListService : DataRequestService<PlayList>, IPlayListService
    {
        public async Task<PlayList> GetPlayListAsync(string channel)
        {
            string url = WebAPI.GetPlayList(channel);
            var result = await GetDataAsync(url);
            return result ?? new PlayList();
        }
    }
}

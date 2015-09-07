using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoubanFM.Models;
using DoubanFM.APIs;

namespace DoubanFM.Services
{
    public class ChannelService : DataRequestService<Channels>, IChannelService
    {
        public async Task<Channels> GetChannelAsync()
        {
            string url = WebAPI.GetChannels();
            var result = await GetDataAsync(url);
            return result ?? new Channels();
        }
    }
}

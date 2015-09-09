using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Performance.Models;
using Performance.APIs;

namespace Performance.Services
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

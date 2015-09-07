using DoubanFM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubanFM.Services
{
    public interface IChannelService
    {
        Task<Channels> GetChannelAsync();
    }
}

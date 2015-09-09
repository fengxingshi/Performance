using Performance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Services
{
    public interface IPlayListService
    {
        Task<PlayList> GetPlayListAsync(string channel);
    }
}

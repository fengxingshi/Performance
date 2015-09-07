using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubanFM.Services
{
    interface IDataRequestService<T>
    {
        Task<T> GetDataAsync(string url);
    }
}

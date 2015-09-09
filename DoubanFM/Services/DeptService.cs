using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoubanFM.Models;
using DoubanFM.APIs;
using Hebcz.ASP.Application.Performance.DataObjects;
using Windows.Web.Http;

namespace DoubanFM.Services
{
    public class DeptService : DataRequestService<Depts>, IDeptService
    {
        public async Task<Depts> GetDeptAsync()
        {
            string url = WebAPI.GetDept("166f67ac-2965-4ec6-841c-fe8b7e61cb9e");
            var result = await GetDataAsync(url);
                        
            return result ?? new Depts();
        }
    }
}

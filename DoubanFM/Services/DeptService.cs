using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Performance.Models;
using Performance.APIs;
using Performance.DataObjects;
using Windows.Web.Http;

namespace Performance.Services
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

using System.Threading.Tasks;
using Performance.Models;
using Performance.APIs;

namespace Performance.Services
{
    public class QueryService : DataRequestService<DeptPes>, IQueryService
    {
        public async Task<DeptPes> GetProgressAsync(long deptId)
        {
            string url = WebAPI.GetPorgress("166f67ac-2965-4ec6-841c-fe8b7e61cb9e",deptId);
            var result = await GetDataAsync(url);                        
            return result ?? new DeptPes{ };
        }
        
    }
}

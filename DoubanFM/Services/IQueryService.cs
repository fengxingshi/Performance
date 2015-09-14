using Performance.Models;
using System.Threading.Tasks;

namespace Performance.Services
{
    public interface IQueryService
    {
        Task<DeptPes> GetProgressAsync(long deptId);
    }
}

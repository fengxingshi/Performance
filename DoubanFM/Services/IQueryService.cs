using Performance.Models;
using System.Threading.Tasks;

namespace Performance.Services
{
    public interface IQueryService
    {
        Task<DeptProgresses> GetProgressAsync(long deptId);
    }
}

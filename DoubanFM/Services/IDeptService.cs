using Performance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Performance.Models;

namespace Performance.Services
{
    public interface IDeptService
    {
        Task<Depts> GetDeptAsync();
    }
}

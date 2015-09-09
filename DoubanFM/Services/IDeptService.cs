using DoubanFM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hebcz.ASP.Application.Performance.DataObjects;

namespace DoubanFM.Services
{
    public interface IDeptService
    {
        Task<Depts> GetDeptAsync();
    }
}

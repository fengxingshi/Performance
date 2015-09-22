using Performance.APIs;
using Performance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace Performance.Services
{
    class MenusService:DataRequestService<Menus>, IMenusService
    {
        public async Task<Menus> GetMenusAsync(string ssxt)
        {
            string url = WebAPI.GetMenus("行政绩效");
            var result = await GetDataAsync(url);
           
            return result ?? new Menus();
        }
    }
}

using DoubanFM.Ioc;
using DoubanFM.Services;
using DoubanFM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubanFM.Locators
{
    public class ViewModelLocator
    {
        private readonly static IDeptService deptService;
        private readonly static IPlayListService playListService;

        static ViewModelLocator()
        {
            ServiceLocator.Default.RegisterSingleton<IDeptService, DeptService>();
            deptService = ServiceLocator.Default.Resolve<IDeptService>();

            ServiceLocator.Default.RegisterSingleton<IPlayListService, PlayListService>();
            playListService = ServiceLocator.Default.Resolve<IPlayListService>();
        }

        public MainPageViewModel Main
        {
            get
            {
                return new MainPageViewModel(deptService, App.NavigationService);
            }
        }

        public PlayListPageViewModel PlayList
        {
            get
            {
                return new PlayListPageViewModel(playListService);
            }
        }
    }
}

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
        private readonly static IChannelService channelService;
        private readonly static IPlayListService playListService;

        static ViewModelLocator()
        {
            ServiceLocator.Default.RegisterSingleton<IChannelService, ChannelService>();
            channelService = ServiceLocator.Default.Resolve<IChannelService>();

            ServiceLocator.Default.RegisterSingleton<IPlayListService, PlayListService>();
            playListService = ServiceLocator.Default.Resolve<IPlayListService>();
        }

        public MainPageViewModel Main
        {
            get
            {
                return new MainPageViewModel(channelService, App.NavigationService);
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

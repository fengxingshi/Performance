using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoubanFM.Models;
using DoubanFM.Services;
using System.ComponentModel;
using DoubanFM.Commands;
using System.Windows.Input;
using DoubanFM.Navigations;

namespace DoubanFM.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IChannelService _channelService;

        public MainPageViewModel(IChannelService channelService, NavigationService navigation)
        {
            this._channelService = channelService;
            LoadChannels();
            ItemClickCommand = new RelayCommand<object>((e) =>
            {
                var parameter = e as Channel;
                navigation.Navigate<Views.PlayListPage>(parameter.ChannelId);
            });
        }

        private Channels channels;

        public Channels Channels
        {
            get { return channels; }
            set
            {
                channels = value;
                OnPropertyChanged(nameof(Channels));
            }
        }

        public ICommand ItemClickCommand { get; set; }

        private async void LoadChannels()
        {
            var result = await _channelService.GetChannelAsync();
            this.Channels = result;
        }
    }
}

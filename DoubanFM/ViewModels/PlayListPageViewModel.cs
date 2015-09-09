using Performance.Commands;
using Performance.Models;
using Performance.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Performance.ViewModels
{
    public class PlayListPageViewModel : ViewModelBase
    {
        private readonly IPlayListService _playListService;

        public PlayListPageViewModel(IPlayListService playListService)
        {
            this._playListService = playListService;
            NavigatedToCommand = new RelayCommand<object>((e) =>
              {
                  this.LoadPlayList(e.ToString());
              });
        }

        private PlayList playList;

        public PlayList PlayList
        {
            get { return playList; }
            set { playList = value;
                OnPropertyChanged(nameof(PlayList));
            }
        }
        
        public ICommand NavigatedToCommand { get; set; }

        private async void LoadPlayList(string channelId)
        {
            var result = await _playListService.GetPlayListAsync(channelId);
            this.PlayList = result;
        }
    }
}

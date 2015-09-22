using Performance.Commands;
using Performance.Models;
using Performance.Navigations;
using Performance.Services;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace Performance.ViewModels
{
    public class MPageViewModel:ViewModelBase
    {
        private readonly IMenusService _menusService;

        public MPageViewModel(IMenusService menusService, NavigationService navigation)
        {
            this._menusService = menusService;
            LoadMenus("行政绩效");
            ItemClickCommand = new RelayCommand<object>((e) =>
            {
                navigation.Navigate<Views.DeptPage>();
            });
            ButtonClickCommand = new RelayCommand<object>((e) =>
            {
                Button bt = e as Button;
                LoadMenus(bt.Name);
            });
            
           
        }

        private Menus menus;

        public Menus Menus
        {
            get { return menus; }
            set
            {
                menus = value;
                OnPropertyChanged(nameof(Menus));
            }
        }

        public ICommand ItemClickCommand { get; set; }
        public ICommand ButtonClickCommand { get; set; }

        private async void LoadMenus(object ssxt)
        {
            var result = await _menusService.GetMenusAsync(ssxt.ToString());
            this.Menus = result;
        }
    }
}

using Performance.Commands;
using Performance.Models;
using Performance.Navigations;
using Performance.Services;
using System.Windows.Input;

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
        public ICommand ButtenClickCommand { get; set; }

        private async void LoadMenus(string ssxt)
        {
            var result = await _menusService.GetMenusAsync(ssxt);
            this.Menus = result;
        }
    }
}

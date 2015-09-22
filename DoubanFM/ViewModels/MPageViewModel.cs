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

        public ICommand MenuClickCommand { get; set; }
        public RelayCommand<object> ButtonClickCommand { get; set; }
       
        public bool IsOpen { get; set; }

        public MPageViewModel(IMenusService menusService, NavigationService navigation)
        {
            this._menusService = menusService;
            IsOpen = false;
            //LoadMenus("行政绩效");
            MenuClickCommand = new RelayCommand<object>((e) =>
            {
                var parameter = e as Menu;
                if (parameter.MCode == "cszbjd")
                {
                    navigation.Navigate<Views.DeptPage>();
                }
                else if (parameter.MCode == "zbgs")
                {
                    navigation.Navigate<Views.PublishKpiPage>();
                }
                else if (parameter.MCode == "ldrc")
                {
                    navigation.Navigate<Views.OALDRCPage>();
                }
            });
            ButtonClickCommand = new RelayCommand<object>((e) =>
            {
                Button bt = e as Button;
                var ssxt = string.Empty;
                if (bt == null)
                {
                    ssxt = "行政绩效";
                }
                LoadMenus(ssxt);
                IsOpen = !IsOpen;

            });


        }

        

        private async void LoadMenus(object ssxt)
        {
            var result = await _menusService.GetMenusAsync(ssxt.ToString());
            this.Menus = result;
        }
    }
}

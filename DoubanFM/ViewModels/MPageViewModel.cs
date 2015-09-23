using Performance.Commands;
using Performance.Models;
using Performance.Navigations;
using Performance.Services;
using System.Collections.Generic;
using System.Windows.Input;
using Windows.UI;
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

        private Controller ctl;

        public Controller Ctl
        {
            get { return ctl; }
            set {
                ctl = value;
                OnPropertyChanged(nameof(Menus));
            }

        }
        private Projects pjs;

        public Projects Pjs
        {
            get { return pjs; }
            set { pjs = value;
                OnPropertyChanged("Projects");
                    }
        }


        public ICommand MenuClickCommand { get; set; }
        public RelayCommand<object> ButtonClickCommand { get; set; }
       
        public bool IsOpen { get; set; }

        public MPageViewModel(IMenusService menusService, NavigationService navigation)
        {
            this._menusService = menusService;
            IsOpen = false;
            Pjs = new Projects();
            Project pj1 = new Project();
            List<Project> list = new List<Project>();
            pj1.PCode = "行政绩效";
            pj1.PName = "行政绩效";
            pj1.PColor = "Blue";
            list.Add(pj1);
            Project pj2 = new Project();
            pj2.PCode = "OA";
            pj2.PName = "办公自动化";
            pj2.PColor = "#00b2f0";
            list.Add(pj2);
            Pjs.ProjectList = list;
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
                var p = e as Project;
                var ssxt = string.Empty;
                if (p == null)
                {
                    ssxt = "行政绩效";
                }
                else
                {
                    ssxt = p.PCode;
                }
                LoadMenus(ssxt);
                Ctl = new Controller();
                Ctl.IsOpen = !IsOpen;
                IsOpen = Ctl.IsOpen;

            });
            //ButtonClickCommand.Execute = new System.Action<object>(LoadMenus)

        }

        

        private async void LoadMenus(object ssxt)
        {
            var result = await _menusService.GetMenusAsync(ssxt.ToString());
            this.Menus = result;
        }
    }
}

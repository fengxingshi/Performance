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
using Hebcz.ASP.Application.Performance.DataObjects;

namespace DoubanFM.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IDeptService _deptService;

        public MainPageViewModel(IDeptService deptService, NavigationService navigation)
        {
            this._deptService = deptService;
            LoadDepts();
            ItemClickCommand = new RelayCommand<object>((e) =>
            {
                var parameter = e as Channel;
                navigation.Navigate<Views.PlayListPage>(parameter.ChannelId);
            });
        }

        private Depts depts;

        public Depts Depts
        {
            get { return depts; }
            set
            {
                depts = value;
                OnPropertyChanged(nameof(Depts));
            }
        }

        public ICommand ItemClickCommand { get; set; }

        private async void LoadDepts()
        {
            var result = await _deptService.GetDeptAsync();
            this.Depts = result;
        }
    }
}

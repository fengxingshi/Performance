using Performance.Models;
using Performance.Services;
using Performance.Commands;
using System.Windows.Input;
using Performance.Navigations;

namespace Performance.ViewModels
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
                var parameter = e as Dept;
                navigation.Navigate<Views.ProgressPage>(parameter.DepartmentID);
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

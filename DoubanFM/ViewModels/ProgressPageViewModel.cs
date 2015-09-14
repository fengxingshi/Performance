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
    public class ProgressPageViewModel : ViewModelBase
    {
        private readonly IQueryService _queryService;

        public ProgressPageViewModel(IQueryService progressListService)
        {
            this._queryService = progressListService;
            NavigatedToCommand = new RelayCommand<object>((e) =>
              {
                  LoadProgressList(Convert.ToInt64(e));
              });
           
        }

        private DeptPes progressList;

        public DeptPes DProgresses
        {
            get { return progressList; }
            set { progressList = value;
                OnPropertyChanged(nameof(DProgresses));
            }
        }
        
        public ICommand NavigatedToCommand { get; set; }

        private async void LoadProgressList(long deptID)
        {
            var result = await _queryService.GetProgressAsync(Convert.ToInt64(deptID));
            this.DProgresses = result;
        }
    }
}

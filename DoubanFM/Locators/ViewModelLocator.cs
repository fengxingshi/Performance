using Performance.Ioc;
using Performance.Services;
using Performance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Locators
{
    public class ViewModelLocator
    {
        private readonly static IDeptService deptService;
        private readonly static IQueryService queryService;

        static ViewModelLocator()
        {
            ServiceLocator.Default.RegisterSingleton<IDeptService, DeptService>();
            deptService = ServiceLocator.Default.Resolve<IDeptService>();
                       
            ServiceLocator.Default.RegisterSingleton<IQueryService, QueryService>();
            queryService = ServiceLocator.Default.Resolve<IQueryService>();
        }

        public MainPageViewModel Main
        {
            get
            {
                return new MainPageViewModel(deptService, App.NavigationService);
            }
        }
        

        public ProgressPageViewModel ProgressList
        {
            get
            {
                return new ProgressPageViewModel(queryService);
            }
        }
    }
}

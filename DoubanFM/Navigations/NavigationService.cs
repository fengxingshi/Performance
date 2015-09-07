using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace DoubanFM.Navigations
{
    public class NavigationService
    {
        private readonly Frame _frame;

        public NavigationService(Frame frame)
        {
            this._frame = frame;
        }

        public void GoBack()
        {
            if (this._frame.CanGoBack)
                this._frame.GoBack();
        }

        public void GoForward()
        {
            if (this._frame.CanGoForward)
                this._frame.GoForward();
        }

        public bool Navigate(Type source, object parameter = null)
        {
            return _frame.Navigate(source, parameter);
        }

        public bool Navigate<T>(object parameter = null)
        {
            var type = typeof(T);
            return Navigate(type, parameter);
        }
    }
}

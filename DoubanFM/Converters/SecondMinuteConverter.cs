using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace DoubanFM.Converters
{
    public class SecondMinuteConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            int time;
            if(int.TryParse(value.ToString(),out time))
            {
                TimeSpan ts = new TimeSpan(0, 0, time);
                return ts.ToString();
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace KeepTrack.Components.Converters
{
    public class NullToBoolConverter : IValueConverter
    {
        public bool NullValue { get; set; } = false;
        public bool NotNullValue { get; set; } = true;

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return value == null ? NullValue : NotNullValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}

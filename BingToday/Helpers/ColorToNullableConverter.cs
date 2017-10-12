using System;
using Windows.UI;
using Windows.UI.Xaml.Data;

namespace BingToday.Helpers
{
    public class ColorToNullableConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is Color color)
            {
                return (Color?)color;
            }

            throw new ArgumentException("value must be Color!");
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
            {
                return Colors.Transparent;
            }

            if (value is Color color)
            {
                return (Color)color;
            }

            throw new ArgumentException("value must be \"Color?\" !");
        }
    }
}

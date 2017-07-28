//  --------------------------------------------------------------------------------------
// MvvmSamples.BooleanToIntegerConverter.cs
// 2017/07/20
//  --------------------------------------------------------------------------------------

using System;
using System.Globalization;
using System.Windows.Data;

namespace MvvmSamples.ValueConverters
{
    public class BooleanToIntegerConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return 0;
            return (bool) value ? 1 : 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int?) value == 1;
        }
    }
}
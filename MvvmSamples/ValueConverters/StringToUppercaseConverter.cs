//  --------------------------------------------------------------------------------------
// MvvmSamples.StringToUppercaseConverter.cs
// 2017/07/20
//  --------------------------------------------------------------------------------------

using System;
using System.Globalization;
using System.Windows.Data;

namespace MvvmSamples.ValueConverters
{
    public class StringToUppercaseConverter : IValueConverter
    {
        public object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            if (value == null)
                return string.Empty;
            return value.ToString().ToUpper();
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            // No changes on the way back.
            return value;
        }
    }
}
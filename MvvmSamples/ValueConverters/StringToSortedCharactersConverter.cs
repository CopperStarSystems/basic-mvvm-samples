//  --------------------------------------------------------------------------------------
// MvvmSamples.StringToSortedCharactersConverter.cs
// 2017/07/20
//  --------------------------------------------------------------------------------------

using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace MvvmSamples.ValueConverters
{
    public class StringToSortedCharactersConverter : IValueConverter
    {
        public object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            if (value == null)
                return null;
            var stringValue = value.ToString().OrderBy(p => p).ToArray();

            return new string(stringValue);
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            return value;
        }
    }
}
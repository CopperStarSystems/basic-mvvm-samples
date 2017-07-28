//  --------------------------------------------------------------------------------------
// MvvmSamples.BooleanToYesNoStringConverter.cs
// 2017/07/20
//  --------------------------------------------------------------------------------------

using System;
using System.Globalization;
using System.Windows.Data;

namespace MvvmSamples.ValueConverters
{
    // It's convention to name your converters [InputType]To[OutputType]Converter
    public class BooleanToYesNoStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return "No";
            var convertedInput = (bool) value;
            return convertedInput ? "Yes" : "No";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return false;
            return value.ToString().ToLower() == "yes";
        }
    }
}
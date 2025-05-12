using System;
using System.Globalization;

using Avalonia.Data.Converters;
using Avalonia.Media;

namespace SimpleC.Workbench.Converter
{
    public class BoolToBrushConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null)
                return value;

            var boolean = (bool)value;

            if (boolean)
                return parameter;

            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

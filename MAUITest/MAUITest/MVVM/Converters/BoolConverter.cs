using System.Globalization;

namespace MAUITest.MVVM.Converters
{
    public class BoolConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var boolValue = (bool)value;
            if (boolValue)
            {
                return "Sí";
            }
            return "No";
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var stringValue = (string)value;
            if (stringValue == "Sí")
            {
                return true;
            }
            return false;
        }
    }
}

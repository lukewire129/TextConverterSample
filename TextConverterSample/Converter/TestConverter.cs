using System.Globalization;
using System.Windows.Data;

namespace TextConverterSample.Converter;

public class TestConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if(value is string str)
        {
            return $"{str} + 1";
        }

        return (string)"";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException ();
    }
}

using System.Globalization;
using System.Windows.Data;

namespace AppTestMVVMBehavior.Helpers
{
    public class InvertedBooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Si el valor es verdadero, el control se colapsa.
            if (value is bool && (bool)value)
            {
                return Visibility.Collapsed;
            }

            // Si es falso, el control es visible.
            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // No es necesario para este caso.
            throw new NotImplementedException();
        }
    }
}

using System.Globalization;
using System.Windows.Data;

namespace AppTestMVVMBehavior.Helpers
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Si el valor es verdadero, el control es Visible.
            if (value is bool && (bool)value)
            {
                return Visibility.Visible;
            }

            // Si es falso, el control está colapsado (no ocupa espacio).
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // La conversión inversa no es necesaria para este caso.
            throw new NotImplementedException();
        }
    }
}

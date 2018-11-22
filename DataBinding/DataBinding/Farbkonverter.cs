using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace DataBinding
{
    class Farbkonverter : IValueConverter
    {
        // Nur One-Way-Binding: Convert reicht aus
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string input = value.ToString();
            if (input == "Rot")
                return Color.Red;
            else if (input == "Gelb")
                return Color.Yellow;
            else if (input == "Grün")
                return Color.Green;
            else
                return Color.Black;
        }

        // Für Two-Way-Binding
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

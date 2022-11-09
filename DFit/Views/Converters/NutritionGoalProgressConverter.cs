using DFit.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFit.Views.Converters
{
    public class NutritionGoalProgressConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length != 2)
                throw new ArgumentException();
            var target = values[0] as Nutrition ?? throw new ArgumentNullException();
            var current = values[1] as Nutrition ?? throw new ArgumentNullException();

            //mean of ratios
            return ((current.KCalCount / target.KCalCount) + (current.ProteinGramCount / target.ProteinGramCount) + (current.WaterLiterCount / target.WaterLiterCount)) / 3;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

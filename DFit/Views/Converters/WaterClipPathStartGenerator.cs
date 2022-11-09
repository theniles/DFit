using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFit.Views.Converters
{
    public class WaterPathStartPointGenerator : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var index = 0;
            var size = (double)values[index++];
            var baseWidth = (double)values[index++];
            var edgeWidth = (double)values[index++];
            var glassHeight = (double)values[index++];
            var waterHeight = (double)values[index++];
            var progress = (double)values[index];

            var ratio = edgeWidth / glassHeight;
            var fullWaterHeight = size * waterHeight;
            var fullGlassHeight = size * glassHeight;
            var opposite = fullWaterHeight * progress;
            var adjacent = opposite * ratio;
            var fullEdgeWidth = size * edgeWidth;
            //return new Point(0, 0);
            return new Point(fullEdgeWidth - adjacent, fullGlassHeight - opposite);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

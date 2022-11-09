using Microsoft.Maui.Controls.Shapes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Path = Microsoft.Maui.Controls.Shapes.Path;

namespace DFit.Views.Converters
{
    public class WaterPathStillPointsGenerator : IMultiValueConverter
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
            var fullBaseWidth = size * baseWidth;

            var points = new Point[3];
            //the 1st point is defined in the PathFigure Start property. It will be the top left of the water
            //objective (abnsolute) coordinates used here 0,0 top left of widget
            points[0] = new Point(fullEdgeWidth, fullGlassHeight);
            points[1] = new Point(fullBaseWidth + fullEdgeWidth, fullGlassHeight);
            points[2] = new Point(fullBaseWidth + fullEdgeWidth + adjacent, fullGlassHeight - opposite);

            return points;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

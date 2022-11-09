using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFit.Views.Converters
{
    public class GlassPathPointsGenerator : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var index = 0;
            var size = (double)values[index++];
            var baseWidth = (double)values[index++];
            var edgeWidth = (double)values[index++];
            var height = (double)values[index];

            var points = new Point[3];
            //the 1st point is defined in the PathFigure Start at 0,0
            //by aligning the path horizontally shit can be centered in the middle
            //its fucked ik
            points[0] = new Point(edgeWidth * size, height * size);
            points[1] = new Point((baseWidth + edgeWidth) * size, height * size);
            points[2] = new Point((baseWidth + (edgeWidth * 2)) * size, 0);

            return new PointCollection(points);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

using DFit.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFit.Views.Converters
{
    public class BezierGlassCurvePointsGenerator  : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var i = 0;
            var bottomMiddleWidth = (double)values[i++]; ;
            var bottomEdgeWidth = (double)values[i++];
            var topMiddleWidth = (double)values[i++];
            var topEdgeWidth = (double)values[i++];
            var topHeight = (double)values[i++];
            var middleHeight = (double)values[i++];
            var bottomHeight = (double)values[i++];

            var side = parameter is string s ? bool.Parse(s) : (bool)parameter;

            var topWidth = topMiddleWidth + (topEdgeWidth * 2);
            var bottomWidth = bottomMiddleWidth + (bottomEdgeWidth * 2);
            var halfMiddleHeight = middleHeight / 2;
            var halfTopWidth = topWidth / 2;
            var halfBottomWidth = bottomWidth / 2;

            var points = new Point[3];
            i = 0;

            //points[i++] = new Point(bottomMiddleWidth / 2, halfMiddleHeight + bottomHeight);

            if(side)
            {
                points[i++] = new Point(halfBottomWidth, halfMiddleHeight);
                points[i++] = new Point(halfTopWidth, -halfMiddleHeight);
                points[i++] = new Point(topMiddleWidth / 2, -halfMiddleHeight - topHeight);
            }
            else
            {
                points[i++] = new Point(-halfTopWidth, -halfMiddleHeight);
                points[i++] = new Point(-halfBottomWidth, halfMiddleHeight);
                points[i++] = new Point(-bottomMiddleWidth / 2, halfMiddleHeight + bottomHeight);
            }

            return points;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

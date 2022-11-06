using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFit.Views.Converters
{
    /// <summary>
    /// <para>
    /// Converts a double, representing an angle of the arc of an ellipse to the points at the end of the arc.
    /// </para>
    /// <para>
    /// Angles measured in radians.
    /// </para>
    /// <para>
    /// Untested with ellipses, designed for circles only, but maybe it would work for ellipses too i just dont 
    /// understand them that well.
    /// </para>
    /// </summary>
    public class ArcSegmentPointConverter : IValueConverter
    {
        /// <summary>
        /// The center of the ellipse.
        /// </summary>
        public Point Center { get; set; }

        /// <summary>
        /// The radius of the ellipse.
        /// </summary>
        public Point Radius { get; set; }

        /// <summary>
        /// An angle offset measured from the positive y axis indicating where the angle of the ellipse should
        /// start.
        /// </summary>
        public double AngleOffset { get; set; }

        /// <summary>
        /// Returns the end point of an arc starting from the positive y axis on this ellipse
        /// </summary>
        /// <param name="angle">The angle of the arc, starting from the positive y axis</param>
        public Point GetPoint(double angle)
        {
            //think bearings

            (var sin, var cos) = Math.SinCos(angle);

            var point = Center;

            point.X += sin * Radius.X;

            point.Y += cos * Radius.Y;

            return point;
        }

        /// <summary>
        /// <para>
        /// Return an end point of an arc on the ellipse defined by an angle
        /// </para>
        /// <para>
        /// Not anymore:
        /// The angle is taken to be the greater angle of the isosceles triangle formed by the points ABC where
        /// A and C are points on the arc and B is the center of the circle
        /// </para>
        /// </summary>
        /// <param name="value">The angle of the arc. Will be added to <see cref="AngleOffset">AngleOffset</see>/></param>
        /// <param name="targetType"></param>
        /// <param name="parameter">A bool indicating which one of the two points to return. True for the one closest clockwise to the positive y axis</param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var angle = (double)value;
            var flag = (bool)parameter;

            if(flag)
            {
                return GetPoint(AngleOffset);
            }
            else
            {
                return GetPoint(AngleOffset + angle);
            }
        }

        /// <summary>
        /// Not implemented.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

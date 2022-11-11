using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFit.Util
{
    public static class Extensions
    {
        public static Point Multiply(this Point self, double factor)
        {
            return new Point(self.X * factor, self.Y * factor);
        }
    }
}

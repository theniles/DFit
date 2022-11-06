using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DFit.Models
{
    public class Nutrition : BindableObject
    {
        public static readonly BindableProperty KCalCountProperty =
            BindableProperty.Create(nameof(KCalCount), typeof(double), typeof(Nutrition), 0d, BindingMode.TwoWay);

        public Nutrition(double kCalCount)
        {
            KCalCount = kCalCount;
        }

        public Nutrition()
        {
        }

        public double KCalCount
        {
            get => (double)GetValue(KCalCountProperty); 
            set => SetValue(KCalCountProperty, value);
        }
    }
}

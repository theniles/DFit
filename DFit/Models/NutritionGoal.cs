using DFit.Views.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DFit.Models
{
    public class NutritionGoal : BindableObject
    {
        public NutritionGoal()
        {
            var binding = new MultiBinding();
            binding.Bindings = new Binding[] {
                new Binding(path: nameof(TargetNutrition) ,source: this),
                new Binding(path: nameof(CurrentNutrition) ,source: this),};

            binding.Converter = new NutritionGoalProgressConverter();
            binding.Mode = BindingMode.OneWayToSource;
            //binding.FallbackValue = 0;

            SetBinding(ProgressProperty, binding);
        }

        public Nutrition CurrentNutrition
        {
            get { return (Nutrition)GetValue(CurrentNutritionProperty); }
            set { SetValue(CurrentNutritionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentNutrition.  This enables animation, styling, binding, etc...
        public static readonly BindableProperty CurrentNutritionProperty =
            BindableProperty.Create(nameof(CurrentNutrition), typeof(Nutrition), typeof(NutritionGoal), defaultValueCreator: bindable => new Nutrition());



        public Nutrition TargetNutrition
        {
            get { return (Nutrition)GetValue(TargetNutritionProperty); }
            set { SetValue(TargetNutritionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TargetNutrition.  This enables animation, styling, binding, etc...
        public static readonly BindableProperty TargetNutritionProperty =
            BindableProperty.Create(nameof(TargetNutrition), typeof(Nutrition), typeof(NutritionGoal), defaultValueCreator: bindable => new Nutrition(2000));



        public double Progress
        {
            get { return (double)GetValue(ProgressProperty); }
            internal set { SetValue(ProgressPropertyKey, value); }
        }

        // Using a DependencyProperty as the backing store for Progress.  This enables animation, styling, binding, etc...
        internal static readonly BindablePropertyKey ProgressPropertyKey =
            BindableProperty.CreateReadOnly(nameof(Progress), typeof(double), typeof(NutritionGoal), 0d);

        public static readonly BindableProperty ProgressProperty = ProgressPropertyKey.BindableProperty;
    }
}

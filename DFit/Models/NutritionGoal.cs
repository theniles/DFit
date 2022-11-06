using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DFit.Models
{
    public class NutritionGoal : INotifyPropertyChanged
    {
        private Nutrition currentNutrition;
        private Nutrition targetNutrition;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public Nutrition CurrentNutrition
        {
            get { return currentNutrition; }
            set
            {
                currentNutrition = value; OnPropertyChanged();
            }
        }

        public Nutrition TargetNutrition
        {
            get { return targetNutrition; }
            set
            {
                targetNutrition = value; OnPropertyChanged();
            }
        }

        public double KCalProgress { get} 
    }
}

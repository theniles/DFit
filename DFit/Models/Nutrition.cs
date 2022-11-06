using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DFit.Models
{
    public class Nutrition : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private int kCalCount = 0;

        public int KCalCount
        {
            get { return kCalCount; }
            set { kCalCount = value; OnPropertyChanged(); }
        }
    }
}

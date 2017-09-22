using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using XFApp.Annotations;
using XFApp.Models;

namespace XFApp.ViewModels
{
    public class EmployeeDetailsViewModel: INotifyPropertyChanged
    {
        public Employee Employee { get; set; }

        public EmployeeDetailsViewModel()
        {
            
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

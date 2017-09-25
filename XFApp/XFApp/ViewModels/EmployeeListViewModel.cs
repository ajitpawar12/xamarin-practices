using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using XFApp.Annotations;
using XFApp.Data;
using XFApp.Models;

namespace XFApp.ViewModels
{
    public class EmployeeListViewModel: INotifyPropertyChanged
    {
        public List<Employee> Employees { get; set; }


        public EmployeeListViewModel()
        {
            //GetAllEmployee();
        }
        private async void GetAllEmployee()
        {
            Employees =await App.EmployeeManager.GetTaskAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;


        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}

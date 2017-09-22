using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFApp.Annotations;
using XFApp.Data;
using XFApp.Models;
using XFApp.Views;

namespace XFApp.ViewModels
{
    public class AddEmployeeViewModel:INotifyPropertyChanged
    {
        IRestService restService=new RestService();
        private string _fullName;
        private string _email;
        private string _phone;
        private double _salary;
        private string _imageUrl;

        public Employee Employee { get; set; }
        public string FullName
        {
            get { return _fullName; }
            set
            {
                _fullName = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertyChanged();
            }
        }

        public double Salary
        {
            get { return _salary; }
            set
            {
                _salary = value;
                OnPropertyChanged();
            }
        }

        public string ImageUrl
        {
            get { return _imageUrl; }
            set
            {
                _imageUrl = value;
                OnPropertyChanged();
            }
        }

        public Command SaveCommand
        {
            get
            {
                return new Command(() =>
                {
                    Employee=new Employee
                    {
                        FullName = _fullName,
                        Email = _email,
                        Salary = _salary,
                        Phone = _phone,
                    };
                    AddEmployee(Employee);

                });
            }
            
        }

        public void AddEmployee(Employee employee)
        {
           restService.SaveEmployee(employee);
        }

        public AddEmployeeViewModel()
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

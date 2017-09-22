using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFApp.Models;

namespace XFApp.ViewModels
{
    public class TaskViewModel:INotifyPropertyChanged
    {
        public TaskViewModel()
        {
            TaskModel=new TaskModel
            {
                Title = "Ui Design",
                Duration = 2
            };
        }

        private TaskModel _taskModel;
        private string _message;

        public TaskModel TaskModel
        {
            get { return _taskModel; }
            set
            {
                _taskModel = value;
                OnPropertyChanged();
            }
        }

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value; 
                OnPropertyChanged();
            }
        }

        public Command SaveCommand {
            get
            {
             return   new Command(() =>
             {
                 Message = "Your tak :" + TaskModel.Title + "," + TaskModel.Duration + " was succsesfully saved !";

             });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

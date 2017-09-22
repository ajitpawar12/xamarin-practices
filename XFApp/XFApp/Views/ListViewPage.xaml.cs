using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFApp.Data;
using XFApp.Models;
using XFApp.ViewModels;

namespace XFApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        //private IRestService _restService=new RestService();

        private List<Speaker> speakers;

        public ListViewPage()
        {
            InitializeComponent();
            BindingContext = new SpeakerViewModel();
        }
        
       
        private async void ListSpeakers_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var speaker = e.SelectedItem as Speaker;
            //var data = _restService.GetValues();

            //var employee = new Employee()
            //{
            //    FullName = "Mohan Mahale",
            //    Email = "mohanm@gmail.com",
            //    Phone = "9639639631",
            //    Salary = 10002.00
            //};
            //var newemp = _restService.SaveEmployee(employee);

            await Navigation.PushAsync(new UserDetailPage(speaker));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFApp.Data;
using XFApp.ViewModels;

namespace XFApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeListPage : ContentPage
    {
        public EmployeeListPage()
        {
            InitializeComponent();
           // BindingContext = new EmployeeListViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            EmployeesListView.ItemsSource = await App.EmployeeManager.GetTaskAsync(); ;
        }

        private async void AddNewButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEmployeePage());
        }
    }
}
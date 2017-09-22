using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFApp.Views;

namespace XFApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void MainButton_OnClicked(object sender, EventArgs e)
        {
            var text = MainEntry.Text;

            MainLabel.Text = "Hello" + text;
        }

        private async void NavigateToMvvmDemoPage_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MvvmDemoPage());
        }

        private async void NavigateToListview_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListViewPage());
        }

        private async void NavigateToEmployee_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EmployeeListPage());
        }
    }
}
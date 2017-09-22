using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFApp.ViewModels;

namespace XFApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MvvmDemoPage : ContentPage
    {
        public MvvmDemoPage()
        {
            InitializeComponent();
            BindingContext = new TaskViewModel();
        }
    }
}
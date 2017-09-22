using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFApp.Models;

namespace XFApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserDetailPage : ContentPage
    {
        public UserDetailPage(Speaker speaker)
        {
            InitializeComponent();
            BindingContext = speaker;
        }
    }
}
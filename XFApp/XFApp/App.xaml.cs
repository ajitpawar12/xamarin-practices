using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XFApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new HomePage());

            //MainPage=new TabbedPage
            //{
            //    Children =
            //    {
            //        new HomePage(),
            //        new SecondPage("Hello World !")
            //    }
            //};
            //MainPage=new CarouselPage
            //{
            //    Children = { new HomePage(),new SecondPage("Hello World !")}
            //};
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

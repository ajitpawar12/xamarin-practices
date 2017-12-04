using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XFApp.Data;

namespace XFApp
{
    public partial class App : Application
    {
        public  static EmployeeManager EmployeeManager {get; private set; }
        public App()
        {
            InitializeComponent();
            EmployeeManager=new EmployeeManager(new RestService());
            MainPage = new XAppMaster();
          
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

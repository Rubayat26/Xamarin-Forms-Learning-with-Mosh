using First_Forms_App.Services;
using First_Forms_App.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace First_Forms_App
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new GreetPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

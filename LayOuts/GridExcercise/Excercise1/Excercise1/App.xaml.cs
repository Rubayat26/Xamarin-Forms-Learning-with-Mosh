using Excercise1.Services;
using Excercise1.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Excercise1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            MainPage = new PhonePage();
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

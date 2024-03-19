using Excercise2.Services;
using Excercise2.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Excercise2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            MainPage = new AbsLayExc2();
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

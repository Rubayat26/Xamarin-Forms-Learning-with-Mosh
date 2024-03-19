using StacLayExcer.Services;
using StacLayExcer.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StacLayExcer
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
           // MainPage = new AppShell();
           MainPage = new StacExcercise();
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

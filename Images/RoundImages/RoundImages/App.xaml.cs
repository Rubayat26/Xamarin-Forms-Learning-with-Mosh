using RoundImages.Services;
using RoundImages.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RoundImages
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
           // MainPage = new AppShell();
            MainPage = new RoundIamgePage();
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

﻿using EmbedImageXml.Services;
using EmbedImageXml.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmbedImageXml
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            MainPage = new ImagePage();
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

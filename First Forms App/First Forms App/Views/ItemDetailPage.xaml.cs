﻿using First_Forms_App.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace First_Forms_App.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
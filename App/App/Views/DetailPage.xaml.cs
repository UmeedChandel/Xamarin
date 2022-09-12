﻿using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Items items)
        {
            InitializeComponent();
            Name.Text = items.Name;
            Price.Text = "Rs." + items.Price.ToString();
            Description.Text = items.LongDescription;
            Img.Source = new UriImageSource()
            {
                Uri = new Uri(items.ImageUrl)
            };
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
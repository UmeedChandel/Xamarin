using App.Models;
using App.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace App.ViewModels
{
    public class DetailPageViewModel: INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public DetailPageViewModel(Items items)
        {
            Name = items.Name;
            Price = items.Price;
            Description = items.LongDescription;
            ImageUrl = items.ImageUrl;
        }

        public Command Button_Clicked {
            get
            {
                return new Command(async () => {
                    await Application.Current.MainPage.Navigation.PopAsync();
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

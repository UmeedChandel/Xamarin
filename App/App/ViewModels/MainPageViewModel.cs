using App.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;
using Xamarin.Forms;

namespace App.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {

        public Command Button_Clicked
        {

            get
            {
                return new Command(async () => {
                    await Application.Current.MainPage.Navigation.PushAsync(new ItemList());
                });
            }
        }
        public Command forgotPasswordTapped
        {

            get
            {
                return new Command(async () =>
                {
                    await Application.Current.MainPage.Navigation.PushAsync(new Tabbed());
                });
            }
        }
        public Command registerTapped
        {

            get
            {
                return new Command(() => { Application.Current.MainPage.DisplayAlert("Register", "You'll have to Sign Up.", "Sign Up"); });
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

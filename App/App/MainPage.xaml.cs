using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemList());
        }

        private async void forgotPasswordTapped(object sender, EventArgs e)
        {
            var email = emailEntry.Text;
            await DisplayAlert("Forgot Password", "Password reset link is sent to " + email + " email address.", "Done");
        }

        private async void registerTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Register", "You'll have to Sign Up.", "Sign Up");
        }
    }
  
}

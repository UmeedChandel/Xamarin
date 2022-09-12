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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var email = userEntry.Text;
            var password = passwordEntry.Text;
            await DisplayAlert("Details", "Email: " + email + "\nPassword: " + password, "Okay");
        }

        private async void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            await DisplayAlert("Remeber Me", "Action.", "Okay");

        }
    }
}
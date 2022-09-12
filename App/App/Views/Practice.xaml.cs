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
    public partial class Pratice : ContentPage
    {
        public Pratice()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Click me again!";
        }

        private async void Button_Clicked_Alert(object sender, EventArgs e)
        {
            var name = commentEntry.Text;
            var nameFeedback = feedbackEditor.Text;
            await DisplayAlert("Alert", name + nameFeedback, "Done");
        }
    }
}
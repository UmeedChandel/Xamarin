using App.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemList : ContentPage
    {
        ObservableCollection<Items> items = new ObservableCollection<Items>();
        public ObservableCollection<Items> ListItems { get { return items; } }
        public ItemList()
        {
            InitializeComponent();
            ItemsList();
        }

        public void ItemsList()
        {
            items.Add(new Items { Name = "Cheese Burger", ShortDescription = "KFC", Distance = 0.3m, ImageUrl = "https://assets.epicurious.com/photos/5c745a108918ee7ab68daf79/1:1/w_2560%2Cc_limit/Smashburger-recipe-120219.jpg", Price = 100, LongDescription = " A hamburger, or simply burger, is a food consisting of fillings—usually a patty of ground meat, typically beef—placed inside a sliced bun or bread roll." });
            items.Add(new Items { Name = "Veggie Burger", ShortDescription = "Burger King", Distance = 0.3m, ImageUrl = "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F43%2F2022%2F06%2F14%2F85452-Homemade-Black-Bean-Veggie-Burger-ddmfs-103085-1x1-1.jpg", Price = 100, LongDescription = "A hamburger, or simply burger, is a food consisting of fillings—usually a patty of ground meat, typically beef—placed inside a sliced bun or bread roll." });
            items.Add(new Items { Name = "Ham Burger", ShortDescription = "McDonald's", Distance = 0.3m, ImageUrl = "https://img.buzzfeed.com/thumbnailer-prod-us-east-1/video-api/assets/165384.jpg", Price = 100, LongDescription = "A hamburger, or simply burger, is a food consisting of fillings—usually a patty of ground meat, typically beef—placed inside a sliced bun or bread roll." });
            items.Add(new Items { Name = "Turkey Burger", ShortDescription = "Burger Hut", Distance = 0.3m, ImageUrl = "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F44%2F2021%2F05%2F10%2Fgrilled-turkey-burgers.jpg&q=60", Price = 100, LongDescription = "A hamburger, or simply burger, is a food consisting of fillings—usually a patty of ground meat, typically beef—placed inside a sliced bun or bread roll." });
            items.Add(new Items { Name = "Cheese Pizza ", ShortDescription = "Pizza Hut", Distance = 0.3m, ImageUrl = "https://preppykitchen.com/wp-content/uploads/2021/10/Cheese-Pizza-Recipe-Card-500x500.jpg", Price = 100, LongDescription = "Pizza is a dish of Italian origin consisting of a usually round, flat base of leavened wheat-based dough topped with tomatoes, cheese, and often various othe ingredients." });
            items.Add(new Items { Name = "Pepperoni Pizza", ShortDescription = "Jumbo Pizza", Distance = 0.3m, ImageUrl = "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F19%2F2014%2F07%2F10%2Fpepperoni-pizza-ck-x.jpg&q=60", Price = 100, LongDescription = "Pizza is a dish of Italian origin consisting of a usually round, flat base of leavened wheat-based dough topped with tomatoes, cheese, and often various other ingredients." });
            items.Add(new Items { Name = "Margherita Pizza", ShortDescription = "Domino's", Distance = 0.3m, ImageUrl = "https://www.vegrecipesofindia.com/wp-content/uploads/2020/12/margherita-pizza-recipe-1.jpg", Price = 100, LongDescription = "Pizza is a dish of Italian origin consisting of a usually round, flat base of leavened wheat-based dough topped with tomatoes, cheese, and often various other ingredients." });
            items.Add(new Items { Name = "Italian Pizza", ShortDescription = "La Pino'z Pizza", Distance = 0.3m, ImageUrl = "https://cdn.shopify.com/s/files/1/2321/3015/products/delicious_italian_pizza_1_570x570_crop_top.png?v=1504536560", Price = 100, LongDescription = "Pizza is a dish of Italian origin consisting of a usually round, flat base of leavened wheat-based dough topped with tomatoes, cheese, and often various other ingredient." });

            ItemView.ItemsSource = ListItems;
        }

        private void ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if(e.Item==null)
            {
                return;
            }
            Navigation.PushAsync(new DetailPage(e.Item as Items), false);
        }
    }
}
using App.Models;
using App.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace App.ViewModels
{
    public class ListViewModel : INotifyPropertyChanged
    {
        private string test = "Loading...";
        public string name
        {
            get { return test; }
            set { test = value; }
        }



        private ObservableCollection<User> _myList;

        public ObservableCollection<User> MyList
        {
            get { return _myList; }
            set { _myList = value; }
        }

        public Command CallAPI
        {

            get
            {
                return new Command(() => { FetchData(); });
            }
        }

        string url = "https://reqres.in/api/users";
        public async void FetchData()
        {
            var client = new HttpClient();
            Uri uri = new Uri(string.Format(url, string.Empty));

            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                var Users = JsonConvert.DeserializeObject<Root>(content);
                MyList = Users.data;
                test = "Loading Complete..";
                OnPropertyChange(nameof(name));
                OnPropertyChange(nameof(MyList));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChange(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}

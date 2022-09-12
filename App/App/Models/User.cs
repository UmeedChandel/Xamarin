using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App.Models
{
    public class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string avatar { get; set; }
    }

    public class Root
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public ObservableCollection<User> data
        {
            get; set;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App1.ViewModels
{
    public class User
    {
        public User(string q)
        {
            Name = q;
        }
        public string Name { get; set; }
    }
    public class SimpleVM : INotifyPropertyChanged
    {
        private User _user;
        public User User { get { return _user; } set { _user = value; OnPropertyChanged("User"); } }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

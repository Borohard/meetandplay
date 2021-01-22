using MeetAndPlayMobileApp.Models;
using MeetAndPlayMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace MeetAndPlayMobileApp.ViewModels
{
    public class InvatesUsersPageViewModal : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        User selectedRequest;

        public ObservableCollection<User> Users { get; set; }
        public INavigation Navigation { get; set; }
        public InvatesUsersPageViewModal()
        {
            Users = new ObservableCollection<User>(Data.UsersData.Users);
        }
        public User SelectedRequest
        {
            get { return selectedRequest; }
            set
            {
                if (selectedRequest != value)
                {
                    User tempRequest = value;
                    selectedRequest = null;
                    OnPropertyChanged("SelectedFriend");
                    Navigation.PushAsync(new AuthorPage(tempRequest));

                }
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}

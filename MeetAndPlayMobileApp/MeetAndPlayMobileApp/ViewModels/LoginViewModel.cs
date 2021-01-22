using MeetAndPlayMobileApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MeetAndPlayMobileApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public ICommand LoginCommand { protected set; get; }
        public ICommand BackButtonCommand { protected set; get; }


        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            BackButtonCommand = new Command(OnBackClicked);
        }

        private async void OnBackClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(UserPage)}");
        }
        
        
    }
}

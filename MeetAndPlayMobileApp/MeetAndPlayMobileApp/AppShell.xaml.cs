using MeetAndPlayMobileApp.ViewModels;
using MeetAndPlayMobileApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MeetAndPlayMobileApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("//app/ProfilePage/loginpage2", typeof(LoginPage));
            Routing.RegisterRoute(nameof(CreateRequestDetailPage), typeof(CreateRequestDetailPage));
            BindingContext = new  RequestsListViewModel() { Navigation = this.Navigation };
            
        }

        private async void OnAboutClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
            //await Shell.Current.GoToAsync("//About");
        }

        private async void OnUserClicked(object sender, EventArgs e)
        {
            // await Navigation.PushAsync(new ProfilePage());
            await Shell.Current.GoToAsync($"//{nameof(ProfilePage)}");
        }
    }
}

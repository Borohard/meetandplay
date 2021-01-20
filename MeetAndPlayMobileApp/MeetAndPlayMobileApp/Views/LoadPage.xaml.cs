using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeetAndPlayMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadPage : ContentPage
    {
        public LoadPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            CheckLogin();
        }

        private async Task CheckLogin()
        {
            // should check for valid login instead
            await Task.Delay(2000);

            // only open Login page when no valid login
            // await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
            await Navigation.PushModalAsync(new LoginPage());
        }
    }
}
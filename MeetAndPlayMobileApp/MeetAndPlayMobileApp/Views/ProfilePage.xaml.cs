using MeetAndPlayMobileApp.Models;
using MeetAndPlayMobileApp.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeetAndPlayMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        JsonAPIService jsonAPIProfilePage;
        public ProfilePage()
        {
            InitializeComponent();
            jsonAPIProfilePage = new JsonAPIService();
            GetProfileInfo();
            
        }


        async void GetProfileInfo()
        {
            User userData = await jsonAPIProfilePage.GetUserDataAsync("https://10.0.2.2:7001/User");
            BindingContext = userData;
        }

        async void OnPickPhotoButtonClicked(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;

            Stream stream = await DependencyService.Get<IPhotoPickerService>().GetImageStreamAsync();
            if (stream != null)
            {
                image.Source = ImageSource.FromStream(() => stream);


            }

        (sender as Button).IsEnabled = true;
        }

        private async void btnGoToLoginPage_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            User userData = await jsonAPIProfilePage.GetUserDataAsync("https://10.0.2.2:7001/User");
            BindingContext = userData;
            var txtTest = txtName.Text;
            
        }
    }
}
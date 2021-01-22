using MeetAndPlayMobileApp.Extensions;
using MeetAndPlayMobileApp.Models;
using Rg.Plugins.Popup.Extensions;
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
    public partial class AuthorPage : ContentPage
    {
        public User ViewModel { get; private set; }
        public AuthorPage(User vm)
        {
            InitializeComponent();
            ViewModel = vm;
            BindingContext = ViewModel;
            authorContent.Title = ViewModel.LastName + " " + ViewModel.FirstName;
            labelGameLevel.Text = ViewModel.GameLevel.GetDescription();
            labelGender.Text = ViewModel.Gender.GetDescription();

        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(new ShowImagePage(ViewModel.UserAvatar));
        }
    }
}
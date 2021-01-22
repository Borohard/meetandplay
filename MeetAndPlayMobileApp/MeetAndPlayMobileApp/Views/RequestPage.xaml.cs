using MeetAndPlayMobileApp.ViewModels;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MeetAndPlayMobileApp.Extensions;
using EnumsNET;
using MeetAndPlayMobileApp.Enums;
using MeetAndPlayMobileApp.Views;

namespace MeetAndPlayMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RequestPage : ContentPage
    {
        public RequestViewModel ViewModel { get; private set; }
        public RequestPage(RequestViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            this.BindingContext = ViewModel;

            // labelGameLevel.Text = EnumExtensions.GetEnumDescription(ViewModel.GameLevel); 
            // labelGameLevel.Text = (EnumExtensions.GetValueFromDescription<GameLevel>("Понимаю как играть, знаю правила")).ToString();
            // labelGameLevel.Text = EnumExtensions.GetEnumDescriptionAtr(vm);
            labelGameLevel.Text = ViewModel.GameLevel.GetDescription();
            labelAuthor.Text = ViewModel.Author.LastName + " " + ViewModel.Author.FirstName;
            labelPlaceType.Text = ViewModel.PlaceType.GetDescription();
            if (ViewModel.IsActive == true)
            {
                btnHello.IsVisible = false;
                btnInvite.IsVisible = false;
                layoutAuthor.IsVisible = false;

            }
            else
            {
                btnInvites.IsVisible = false;
                btnEdit.IsVisible = false;
                
            }

        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(new ShowImagePage(ViewModel.ImageOfRequest) );
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AuthorPage(ViewModel.Author));
        }

        private async void btnInvites_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InvatesUsersPage());
        }
    }
}
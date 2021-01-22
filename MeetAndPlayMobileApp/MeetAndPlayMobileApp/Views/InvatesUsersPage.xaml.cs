using MeetAndPlayMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetAndPlayMobileApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Extensions;

namespace MeetAndPlayMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InvatesUsersPage : ContentPage
    {
        

        public InvatesUsersPage()
        {
            InitializeComponent();
            //usersCollection.SelectedItem += requests_Selected();
            BindingContext = new InvatesUsersPageViewModal() { Navigation = this.Navigation };
        }

        private void requestsCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (usersCollection.SelectedItem != null)
            {
                usersCollection.SelectedItem = null;
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushPopupAsync(new ShowMessegeText());
        }
    }
}
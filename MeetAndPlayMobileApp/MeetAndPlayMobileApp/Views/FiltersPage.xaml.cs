using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetAndPlayMobileApp.ViewModels;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeetAndPlayMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FiltersPage : PopupPage
    {
        public RequestsListViewModel ViewModel { get; private set; }
        public FiltersPage(RequestsListViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            this.BindingContext = ViewModel;
           
            dateFilterFrom.MinimumDate = DateTime.Today;
            dateFilterTo.MinimumDate = DateTime.Today;

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           
            await PopupNavigation.Instance.PopAsync();
            //await Shell.Current.GoToAsync($"//{nameof(HomePage)  }") ;
        }

        protected override bool OnBackButtonPressed()
        {
            // Return true if you don't want to close this popup page when a back button is pressed
            return true;
        }
    }
}
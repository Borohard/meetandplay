using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetAndPlayMobileApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeetAndPlayMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowImagePage  : PopupPage
    {
        public RequestViewModel ViewModel { get; private set; }
        public ImageSource ImageSource { get; set; }
        public ShowImagePage(RequestViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            BindingContext = ViewModel;
            //imageItem.Source = ImageSource;
            
            
        }

        private async void backButton_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }

        protected override bool OnBackButtonPressed()
        {
            PopupNavigation.Instance.PopAsync();
            return true;
        }
    }
}
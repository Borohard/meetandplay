using MeetAndPlayMobileApp.ViewModels;
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
    public partial class RequestPage : ContentPage
    {
        public RequestViewModel ViewModel { get; private set; }
        public RequestPage(RequestViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            this.BindingContext = ViewModel;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(new ShowImagePage(ViewModel) );
        }
    }
}
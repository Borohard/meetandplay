using MeetAndPlayMobileApp.ViewModels;
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
    public partial class CreateRequestDetailPage : ContentPage
    {
        public RequestViewModel ViewModel { get; private set; }


        public CreateRequestDetailPage(RequestViewModel vm)
        {

            InitializeComponent();

            
           

            ViewModel = vm;
            dateTimeEventPicker.PropertyChanged += DateTimeEventPicker_PropertyChanged;


            this.BindingContext = ViewModel;
            btnPublisher.Pressed += BtnPublisher_Pressed;
        }

        private void BtnPublisher_Pressed(object sender, EventArgs e)
        {

        }

        private void DateTimeEventPicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            ViewModel.PlannedGameDate = dateTimeEventPicker.DateTime;
        }
    }
}
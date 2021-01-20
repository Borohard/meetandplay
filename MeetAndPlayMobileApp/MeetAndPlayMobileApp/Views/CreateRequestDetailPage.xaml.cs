using MeetAndPlayMobileApp.Models;
using MeetAndPlayMobileApp.Services;
using MeetAndPlayMobileApp.ViewModels;
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
    public partial class CreateRequestDetailPage : ContentPage
    {
        public RequestViewModel ViewModel { get; private set; }
        INotificationManager notificationManager;
        int notificationNumber = 0;

        public CreateRequestDetailPage(RequestViewModel vm)
        {

            InitializeComponent();
            pickerPlaceType.BackgroundColor = Color.White;

            notificationManager = DependencyService.Get<INotificationManager>();
            notificationManager.NotificationReceived += (sender, eventArgs) =>
            {
                var evtData = (NotificationEventArgs)eventArgs;
                ShowNotification(evtData.Title, evtData.Message);
            };

            ViewModel = vm;
            dateTimeEventPicker.PropertyChanged += DateTimeEventPicker_PropertyChanged;
            image.PropertyChanged += Image_PropertyChanged;

            this.BindingContext = ViewModel;
            
            
        }

        private void Image_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            ViewModel.ImageOfRequest = image.Source;

        }

        private void BtnPublisher_Pressed(object sender, EventArgs e)
        {
            notificationNumber++;
            string title = $"Local Notification #{notificationNumber}";
            string message = $"You have now received {notificationNumber} notifications!";
            notificationManager.SendNotification(title, message);
        }

        private void DateTimeEventPicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            ViewModel.PlannedGameDate = dateTimeEventPicker.DateTime;
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

        private void image_PropertyChanging(object sender, PropertyChangingEventArgs e)
        {
            ViewModel.ImageOfRequest = image.Source;
        }

        void ShowNotification(string title, string message)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                var msg = new Label()
                {
                    Text = $"Notification Received:\nTitle: {title}\nMessage: {message}"
                };
                stackLayout.Children.Add(msg);
            });
        }
    }
}
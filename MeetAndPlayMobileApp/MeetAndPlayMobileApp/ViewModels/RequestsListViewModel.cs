using MeetAndPlayMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MeetAndPlayMobileApp.ViewModels
{
    public class RequestsListViewModel : INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<RequestViewModel> Requests { get; set; }

        
        public ICommand CreateRequestCommand { protected set; get; }
        public ICommand DeleteRequestCommand { protected set; get; }
        public ICommand SaveRequestCommand { protected set; get; }
        public ICommand ChangeRequestCommand { protected set; get; }
        RequestViewModel selectedRequest;
        public INavigation Navigation { get; set; }

        public RequestsListViewModel()
        {
            Requests = new ObservableCollection<RequestViewModel>();

            //Из даты не выгружается, попробовал прямо сюда
            Requests.Add(new RequestViewModel
            {
                FoundCategory = Enums.FoundCategory.Team,
                NameOfTheGame = "Манчкин",
                GameLevel = Enums.GameLevel.Pro,
                Description = "Всем привет, я со своей девушкой и другом хотим провести вечер за настолками, ищем компанию",
                CurrentPlayersCount = 3,
                MaxPlayersCount = 6,
                PlannedGameDate = new DateTime(2008, 4, 10, 6, 30, 0),
                PlaceType = Enums.PlaceType.Cafe
            });

            CreateRequestCommand = new Command(CreateRequest);
            DeleteRequestCommand = new Command(DeleteRequest);
            SaveRequestCommand = new Command(SaveRequest);
            ChangeRequestCommand = new Command(ChangeRequest);

        }
        public RequestViewModel SelectedRequest
        {
            get { return selectedRequest; }
            set
            {
                if (selectedRequest != value)
                {
                    RequestViewModel tempRequest = value;
                    selectedRequest = null;
                    OnPropertyChanged("SelectedFriend");
                    Navigation.PushAsync(new CreateRequestDetailPage(tempRequest));
                }
            }
        }
        private void Back()
        {
            Navigation.PopAsync();
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        private void ChangeRequest(object obj)
        {
            throw new NotImplementedException();
        }

        private void SaveRequest(object requestObject)
        {
            RequestViewModel request = requestObject as RequestViewModel;
            if (request != null)
            {
                Requests.Add(request);
            }
            Back();
        }

        private void DeleteRequest(object requestObject)
        {
            RequestViewModel request = requestObject as RequestViewModel;
            if (request != null)
            {
                Requests.Remove(request);
            }
            Back();
        }

        private void CreateRequest(object obj)
        {
            Navigation.PushModalAsync(new CreateRequestDetailPage(new RequestViewModel() { ListViewModel = this }));

        }

        private async void OnAddItem(object obj)
        {
            await Shell.Current.GoToAsync(nameof(CreateRequestDetailPage));
        }
    }
}

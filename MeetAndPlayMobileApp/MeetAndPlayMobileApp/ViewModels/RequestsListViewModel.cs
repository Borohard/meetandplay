﻿using MeetAndPlayMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Rg.Plugins.Popup.Extensions;
using System.Linq;
using MeetAndPlayMobileApp.Enums;
using System.Net.Http;


namespace MeetAndPlayMobileApp.ViewModels
{
    public class RequestsListViewModel : INotifyPropertyChanged
    {

        
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<RequestViewModel> TempRequests { get; set; }
        public ObservableCollection<RequestViewModel> Requests { get; set; }
        bool isRefreshing;
        
        public ICommand FilterListCommand { protected set; get; }
        public ICommand RefreshCommand { get; }
        public ICommand OpenFilterPage { protected set; get; }
        public ICommand CreateRequestCommand { protected set; get; }
        public ICommand DeleteRequestCommand { protected set; get; }
        public ICommand SaveRequestCommand { protected set; get; }
        public ICommand ChangeRequestCommand { protected set; get; }

        RequestViewModel selectedRequest;

        object defaultRefrash;

        public INavigation Navigation { get; set; }
        public DateTime DateFilterFrom { get; set; }
        public DateTime DateFilterTo { get; set; }
        public GameLevel GameLevelFilter { get; set; }
        public PlaceType PlaceTypeFilter { get; set; }

        public string GameTitleFilter { get; set; }


        public RequestsListViewModel()
        {
            var client = new HttpClient();
            
            
            Requests = new ObservableCollection<RequestViewModel>(Data.RequestData.Requests);
          //  ExecuteRefreshCommand(defaultRefrash);
            
            /*Из даты не выгружается, попробовал прямо сюда
            Requests.Add(new RequestViewModel
            {
                Title = "Хотим поиграть в манчкин", ImageOfRequest = "Manc.png", NameOfTheGame = "Манчкин", GameLevel = Enums.GameLevel.Middle,Description = "Всем привет, я со своей девушкой и другом хотим провести вечер за настолками, ищем компанию",
                CurrentPlayersCount = 3,MaxPlayersCount = 5,PlannedGameDate = new DateTime(2021, 4, 10, 3, 30, 0),PlaceType = Enums.PlaceType.Cafe        
            });

            Requests.Add(new RequestViewModel
            {
                Title = "Ищем одного человека для игры",ImageOfRequest = "Place2.jpg", NameOfTheGame = "За бортом", GameLevel = Enums.GameLevel.Middle,
                Description = "Хотим поиграть в приятной атмосфере",CurrentPlayersCount = 4, MaxPlayersCount = 5,PlannedGameDate = new DateTime(2021, 4, 10, 18, 30, 0), PlaceType = Enums.PlaceType.Home
            });

            Requests.Add(new RequestViewModel
            {
                Title = "Монополия на века",ImageOfRequest = "Place3.jpg",NameOfTheGame = "Монополия",GameLevel = Enums.GameLevel.Middle,MaxPlayersCount = 5,
                 Description = "Всем привет, я со своей девушкой и другом хотим провести вечер за настолками, ищем компанию", CurrentPlayersCount = 1,PlannedGameDate = new DateTime(2021, 4, 10, 18, 30, 0), PlaceType = Enums.PlaceType.Home  
            });*/

            CreateRequestCommand = new Command(CreateRequest);
            DeleteRequestCommand = new Command(DeleteRequest);
            SaveRequestCommand = new Command(SaveRequest);
            ChangeRequestCommand = new Command(ChangeRequest);
            OpenFilterPage = new Command(OnAddFilter);
            RefreshCommand = new Command(ExecuteRefreshCommand);
            FilterListCommand = new Command(FilterCommand);

        }

        public bool IsRefreshing
        {
            get => isRefreshing;
            set
            {
                isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        
        private void ExecuteRefreshCommand(object obj)
        {
            if (IsRefreshing)
                return;         
            
            IsRefreshing = true;

            Requests.Clear();
            
            foreach (var request in Data.RequestData.Requests)
            {
                Requests.Add(request);
            }
            
            IsRefreshing = false;
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
                    Navigation.PushAsync(new RequestPage(tempRequest));
                    
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
                request.IsActive = true;
                request.Author = new Models.User()
                {
                    FirstName = "Алина",
                    LastName = "Василенко",
                    AboutUser = "Всем привет, я студентка Урфу, живу на ЖБИ, все друзья работают, а я пока что учусь, поэтому у меня много свободного времени,буду рада поиграть  в различные настолки",
                    UserGames = "Дженга,Манчкин, Твистер, Алиес",
                    Gender = Enums.Gender.Female,
                    BirthDate = new DateTime(1999, 3, 6),
                    FreeTime = "Каждый день после 7",
                    GameLevel = Enums.GameLevel.Middle,
                    UserEmail = "vasssilenko@Gmail",
                    UserSocialNetworks = "id2348765",
                    UserPhoneNumber = "89000515151",
                    UserAvatar = "Alina"
                };
                Data.RequestData.Requests.Add(request);
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

        private async void CreateRequest(object obj)
        {
            await Navigation.PushModalAsync(new CreateRequestDetailPage(new RequestViewModel() { ListViewModel = this }));
        }

        private async void OnAddItem(object obj)
        {
            await Shell.Current.GoToAsync(nameof(CreateRequestDetailPage));
        }

        private async void OnAddFilter(object obj)
        {
           await Navigation.PushPopupAsync(new FiltersPage(this));
            //await Navigation.PushModalAsync(new FiltersPage());
        }

        private void FilterCommand()
        {
            
            //TempRequests = Requests;
            Requests.Clear();
            //  Requests = new ObservableCollection<RequestViewModel>(tempRequestsList.Where((request) => request.PlannedGameDate.ToString().Contains(DateFilter.ToString()))); 

            //TempRequests = new ObservableCollection<RequestViewModel>(Data.RequestData.Requests.Where( (request) => request.PlannedGameDate.Date.Day.ToString().Contains(DateFilterFrom.Day.ToString())));
            TempRequests = new ObservableCollection<RequestViewModel>(Data.RequestData.Requests.Where(r => r.PlannedGameDate >= DateFilterFrom && r.PlannedGameDate <= DateFilterTo));

            if (GameTitleFilter != null)
                TempRequests = new ObservableCollection<RequestViewModel>(TempRequests.Where((request) => request.NameOfTheGame.ToLower().Contains(GameTitleFilter.ToLower())));


            if (PlaceTypeFilter != PlaceType.Undefined)
            TempRequests = new ObservableCollection<RequestViewModel>(TempRequests.Where(r => r.PlaceType == PlaceTypeFilter));

            if (GameLevelFilter != GameLevel.Undefined)
                TempRequests = new ObservableCollection<RequestViewModel>(TempRequests.Where(r => r.GameLevel == GameLevelFilter));

            foreach (var request in TempRequests)
            {
                Requests.Add(request);
            } 
        }
    }
}

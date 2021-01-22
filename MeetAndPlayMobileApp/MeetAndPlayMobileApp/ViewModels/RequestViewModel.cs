using MeetAndPlayMobileApp.Enums;
using MeetAndPlayMobileApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace MeetAndPlayMobileApp.ViewModels
{
    public class RequestViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        RequestsListViewModel lvm;



        public Request Request { get; private set; }
        public RequestViewModel()
        {
            Request = new Request();
        }

        
        public RequestsListViewModel ListViewModel
        {
            get { return lvm; }
            set
            {
                if (lvm != value)
                {
                    lvm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }


        public User Author
        {
            get { return Request.Author; }
            set
            {
                if (Request.Author != value)
                {
                    Request.Author = value;
                    OnPropertyChanged("Author");
                }
            }
        }

        public ImageSource ImageOfRequest
        {
            get { return Request.ImageOfRequest; }
            set
            {
                if (Request.ImageOfRequest != value)
                {
                    Request.ImageOfRequest = value;
                    OnPropertyChanged("ImageOfRequest");
                }
            }
        }

        public string NameOfTheGame
        {
            get { return Request.NameOfTheGame; }
            set
            {
                if (Request.NameOfTheGame != value)
                {
                    Request.NameOfTheGame = value;
                    OnPropertyChanged("NameOfTheGame");
                }
            }
        }
        public string Title
        {
            get { return Request.Title; }
            set
            {
                if (Request.Title != value)
                {
                    Request.Title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        public FoundCategory FoundCategory
        {
            get { return Request.FoundCategory; }
            set
            {
                if (Request.FoundCategory != value)
                {
                    Request.FoundCategory = value;
                    OnPropertyChanged("FoundCategory");
                }
            }
        }

        public GameLevel GameLevel
        {
            get { return Request.GameLevel; }
            set
            {
                if (Request.GameLevel != value)
                {
                    Request.GameLevel = value;
                    OnPropertyChanged("GameLevel");
                }
            }
        }
        public string Description
        {
            get { return Request.Description; }
            set
            {
                if (Request.Description != value)
                {
                    Request.Description = value;
                    OnPropertyChanged("Description");
                }
            }
        }
        public int CurrentPlayersCount
        {
            get { return Request.CurrentPlayersCount; }
            set
            {
                if (Request.CurrentPlayersCount != value)
                {
                    Request.CurrentPlayersCount = value;
                    OnPropertyChanged("CurrentPlayersCount");
                }
            }
        }
        public int MaxPlayersCount
        {
            get { return Request.MaxPlayersCount; }
            set
            {
                if (Request.MaxPlayersCount != value)
                {
                    Request.MaxPlayersCount = value;
                    OnPropertyChanged("MaxPlayersCount");
                }
            }
        }
        public bool IsActive
        {
            get { return Request.IsActive; }
            set
            {
                if (Request.IsActive != value)
                {
                    Request.IsActive = value;
                    OnPropertyChanged("IsActive");
                }
            }
        }



        public DateTime CreationDate
        {
            get { return Request.CreationDate; }
            set
            {
                if (Request.CreationDate != value)
                {
                    Request.CreationDate = value;
                    OnPropertyChanged("CreationDate");
                }
            }
        }
        public DateTime PlannedGameDate
        {
            get { return Request.PlannedGameDate; }
            set
            {
                if (Request.PlannedGameDate != value)
                {
                    Request.PlannedGameDate = value;
                    OnPropertyChanged("PlannedGameDate");
                }
            }
        }

        public PlaceType PlaceType
        {
            get { return Request.PlaceType; }
            set
            {
                if (Request.PlaceType != value)
                {
                    Request.PlaceType = value;
                    OnPropertyChanged("PlaceType");
                }
            }
        }


        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}

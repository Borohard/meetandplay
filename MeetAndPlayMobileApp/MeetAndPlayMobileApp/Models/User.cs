using MeetAndPlayMobileApp.Enums;
using MeetAndPlayMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace MeetAndPlayMobileApp.Models
{
    public class User
    {
        public ImageSource UserAvatar { get; set; }


        [JsonProperty("helloMessege")]
        public string HelloMessege { get; set; }


        [JsonProperty("firstName")]
        public string FirstName { get; set; }


        [JsonProperty("lastName")]
        public string LastName { get; set; }


        [JsonProperty("gender")]
        public Gender Gender { get; set; }

       
        [JsonProperty("birthDate")]
        public DateTime BirthDate { get; set; }


        [JsonProperty("aboutUser")]
        public string AboutUser { get; set; }


        [JsonProperty("freeTime")]
        public string FreeTime { get; set; }


        [JsonProperty("userGames")]
        public string UserGames { get; set; }

        [JsonProperty("userSocialNetworks")]
        public string UserSocialNetworks { get; set; }

        [JsonProperty("userGameLevel")]
        public GameLevel GameLevel { get; set; }

        [JsonProperty("userPhoneNumber")]
        public string UserPhoneNumber { get; set; }


        [JsonProperty("userEmail")]
        public string UserEmail { get; set; }

        [JsonProperty("userRequests")]
        public ObservableCollection<RequestViewModel> UserRequests { get; set; }
    }
}

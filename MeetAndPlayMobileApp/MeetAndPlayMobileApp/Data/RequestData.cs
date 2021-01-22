using MeetAndPlayMobileApp.Models;
using MeetAndPlayMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MeetAndPlayMobileApp.Data
{
    public static class RequestData
    {
        public static ObservableCollection<RequestViewModel> Requests { get; private set; }

        static RequestData()
        {
            Requests = new ObservableCollection<RequestViewModel>();

            Requests.Add(new RequestViewModel
            {
                //Author = (User)UsersData.Users.Where(user => user.FirstName.Contains("Алина")) 

                Author = new User()
                {
                    FirstName = "Алина",LastName = "Василенко",AboutUser = "Всем привет, я студентка Урфу, живу на ЖБИ, все друзья работают, а я пока что учусь, поэтому у меня много свободного времени,буду рада поиграть  в различные настолки",
                    UserGames = "Дженга,Манчкин, Твистер, Алиес",Gender = Enums.Gender.Female,BirthDate = new DateTime(1999, 3, 6),FreeTime = "Каждый день после 7",GameLevel = Enums.GameLevel.Middle,UserEmail = "vasssilenko@Gmail", UserSocialNetworks = "id2348765",UserPhoneNumber = "89000515151",UserAvatar = "Alina"               
                },
                Title = "Хотим поиграть в манчкин",ImageOfRequest = "Manc.png",FoundCategory = Enums.FoundCategory.Team,NameOfTheGame = "Манчкин",GameLevel = Enums.GameLevel.Pro,Description = "Всем привет, я со своей девушкой и другом хотим провести вечер за настолками, ищем компанию",
                CurrentPlayersCount = 3,MaxPlayersCount = 6,PlannedGameDate = new DateTime(2021, 2, 10, 6, 30, 0),PlaceType = Enums.PlaceType.Cafe
            }); 

            Requests.Add(new RequestViewModel
            {
                Author = new User()
                {
                    FirstName = "Алина",LastName = "Василенко",AboutUser = "Всем привет, я студентка Урфу, живу на ЖБИ, все друзья работают, а я пока что учусь, поэтому у меня много свободного времени,буду рада поиграть  в различные настолки",
                    UserGames = "Дженга,Манчкин, Твистер, Алиес",Gender = Enums.Gender.Female,BirthDate = new DateTime(1999, 3, 6),FreeTime = "Каждый день после 7",GameLevel = Enums.GameLevel.Middle,UserEmail = "vasssilenko@Gmail", UserSocialNetworks = "id2348765",UserPhoneNumber = "89000515151",UserAvatar = "Alina"               
                },
                
                Title = "Ищем одного человека для игры",ImageOfRequest = "Anticafe",FoundCategory = Enums.FoundCategory.Team,NameOfTheGame = "Дженга",GameLevel = Enums.GameLevel.Pro,Description = "Ищу компанию для игры в дженгу, не стесяйтесь писать",
                CurrentPlayersCount = 1,MaxPlayersCount = 6, PlannedGameDate = new DateTime(2021, 1, 31, 1, 1, 0), PlaceType = Enums.PlaceType.Home                                                             
            });

            Requests.Add(new RequestViewModel
            {
                Author = new User()
                {
                    FirstName = "Алина",LastName = "Василенко",AboutUser = "Всем привет, я студентка Урфу, живу на ЖБИ, все друзья работают, а я пока что учусь, поэтому у меня много свободного времени,буду рада поиграть  в различные настолки",
                    UserGames = "Дженга,Манчкин, Твистер, Алиес",Gender = Enums.Gender.Female,BirthDate = new DateTime(1999, 3, 6),FreeTime = "Каждый день после 7",GameLevel = Enums.GameLevel.Middle,UserEmail = "vasssilenko@Gmail", UserSocialNetworks = "id2348765",UserPhoneNumber = "89000515151",UserAvatar = "Alina"               
                },
                
                Title = "Монополия на века",ImageOfRequest = "Anticafe",FoundCategory = Enums.FoundCategory.Team,NameOfTheGame = "Монополия",GameLevel = Enums.GameLevel.Noob,Description = "Всем привет, хочу научиться играть в монополию, но не с кем, ищу команду",
                CurrentPlayersCount = 1,MaxPlayersCount = 6,PlannedGameDate = new DateTime(2021, 4, 10, 19, 30, 0),PlaceType = Enums.PlaceType.Lounge               
            });

            Requests.Add(new RequestViewModel
            {
                Author = new User()
                {
                    FirstName = "Алина",LastName = "Василенко",AboutUser = "Всем привет, я студентка Урфу, живу на ЖБИ, все друзья работают, а я пока что учусь, поэтому у меня много свободного времени,буду рада поиграть  в различные настолки",
                    UserGames = "Дженга,Манчкин, Твистер, Алиес",Gender = Enums.Gender.Female,BirthDate = new DateTime(1999, 3, 6),FreeTime = "Каждый день после 7",GameLevel = Enums.GameLevel.Middle,UserEmail = "vasssilenko@Gmail", UserSocialNetworks = "id2348765",UserPhoneNumber = "89000515151",UserAvatar = "Alina"               
                },
                
                Title = "Любите колонизировать?:)",FoundCategory = Enums.FoundCategory.Team,NameOfTheGame = "Колонизаторы",GameLevel = Enums.GameLevel.Middle,Description = "Всем привет, я с другом хотим поиграть в колонизаторов, но у нас нет самой игры, играем на нормальном уровне, ищем двух человек, встретиться желательно в кафе",
                CurrentPlayersCount = 2,MaxPlayersCount = 4,PlannedGameDate = new DateTime(2021, 1, 27, 21, 00, 0),PlaceType = Enums.PlaceType.Cafe               
            });
        }
    }
}

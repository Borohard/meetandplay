using MeetAndPlayMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeetAndPlayMobileApp.Data
{
    public class RequestData
    {
        public static IList<Request> Requests { get; set; }

        public RequestData()
        {
            Requests = new List<Request>();

            Requests.Add(new Request
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

            Requests.Add(new Request
            {
                FoundCategory = Enums.FoundCategory.Team,
                NameOfTheGame = "Дженга",
                GameLevel = Enums.GameLevel.Pro,
                Description = "Идите нах епта один буду играть",
                CurrentPlayersCount = 1,
                MaxPlayersCount = 6,
                PlannedGameDate = new DateTime(2021, 1, 1, 1, 1, 0),
                PlaceType = Enums.PlaceType.Cafe
            });

            Requests.Add(new Request
            {
                FoundCategory = Enums.FoundCategory.Team,
                NameOfTheGame = "Монополия",
                GameLevel = Enums.GameLevel.Noob,
                Description = "Всем привет, хочу научиться играть в монополию, но не с кем, ищу команду",
                CurrentPlayersCount = 1,
                MaxPlayersCount = 6,
                PlannedGameDate = new DateTime(2021, 4, 10, 19, 30, 0),
                PlaceType = Enums.PlaceType.Cafe
            });

            Requests.Add(new Request
            {
                FoundCategory = Enums.FoundCategory.Team,
                NameOfTheGame = "Колонизаторы",
                GameLevel = Enums.GameLevel.Middle,
                Description = "Всем привет, я с другом хотим поиграть в колонизаторов, но у нас нет самой игры, играем на нормальном уровне, ищем двух человек, встретиться желательно в кафе",
                CurrentPlayersCount = 2,
                MaxPlayersCount = 4,
                PlannedGameDate = new DateTime(2020, 12, 27, 21, 00, 0),
                PlaceType = Enums.PlaceType.Cafe
            });
        }
    }
}

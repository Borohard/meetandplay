﻿
using MeetAndPlayMobileApp.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeetAndPlayMobileApp.Models
{
    public class Request
    {
        public FoundCategory FoundCategory { get; set; }
        public string NameOfTheGame { get; set; }

        public GameLevel GameLevel { get; set; }
        public string Description { get; set; }
        public int CurrentPlayersCount { get; set; }
        public int MaxPlayersCount { get; set; }
        public bool IsActive { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime PlannedGameDate { get; set; }

        public PlaceType PlaceType { get; set; }

    }
}
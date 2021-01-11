using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace MeetAndPlayMobileApp.Enums
{
    public enum FoundCategory
    {
        [Description("Не задано")]
        Nobody,
        [Description("Команду")]
        Team,
        [Description("Игрока")]
        PLayer
    }
}

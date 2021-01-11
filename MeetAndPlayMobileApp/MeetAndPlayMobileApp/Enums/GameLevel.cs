using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MeetAndPlayMobileApp.Enums
{
    public enum GameLevel
    {
        [Description("Не задано")]
        Undefined,
        [Description("Не знаю как играть")]
        Noob,
        [Description("Понимаю как играть, знаю правила")]
        Middle,
        [Description("Подержи моё пиво, сынок")]
        Pro
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MeetAndPlayMobileApp.Enums
{
    public enum PlaceType
    {
        [Description("Не задано")]
        Undefined,
        [Description("Дома")]
        Home,
        [Description("В кафе")]
        Cafe,
        [Description("В лаундж баре")]
        Lounge,
    }
}

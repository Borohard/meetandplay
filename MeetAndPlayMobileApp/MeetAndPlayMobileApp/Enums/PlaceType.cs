using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MeetAndPlayMobileApp.Enums
{
    public enum PlaceType
    {

        [Display(Description = " ")]
        [Description(" ")]
        Undefined,
        [Display(Description = "Дома")]
        [Description("Дома")]
        Home,
        [Display(Description = "В кафе")]
        [Description("В кафе")]
        Cafe,
        [Display(Description = "В лаундж баре")]
        [Description("В лаундж баре")]
        Lounge,
    }
}

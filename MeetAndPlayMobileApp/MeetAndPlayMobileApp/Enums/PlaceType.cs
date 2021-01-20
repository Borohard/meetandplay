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
        Undefined,
        [Display(Description = "Дома")]
        Home,
        [Display(Description = "В кафе")]
        Cafe,
        [Display(Description = "В лаундж баре")]
        Lounge,
    }
}

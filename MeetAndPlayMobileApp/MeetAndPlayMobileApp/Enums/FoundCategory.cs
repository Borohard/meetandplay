using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MeetAndPlayMobileApp.Enums
{
    public enum FoundCategory
    {
        [Display(Description = "Не важно")]       
        Nobody,
        [Display(Description = "Команду")]
        Team,
        [Display(Description = "Игрока")]
        PLayer
    }
}

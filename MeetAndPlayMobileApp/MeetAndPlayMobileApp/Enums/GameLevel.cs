using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MeetAndPlayMobileApp.Enums
{
    public enum GameLevel
    {
        [Display(Description = " ")]
        Undefined,       
        [Display(Description = "Не знаю как играть")]
        Noob,
        [Display(Description = "Понимаю как играть, знаю правила")]        
        Middle,
        [Display(Description = "Подержи моё пиво, сынок")]        
        Pro
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MeetAndPlayMobileApp.Enums
{   
        public enum Gender
        {
            [Display(Description = "Мужчина")]
            Male,
            [Display(Description = "Женщина")]
            Female
        }
    
}

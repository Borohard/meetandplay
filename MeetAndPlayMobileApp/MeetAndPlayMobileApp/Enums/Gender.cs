using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MeetAndPlayMobileApp.Enums
{   
        public enum Gender
        {
            [Display(Description = "Мужчина")]
            [Description("Мужчина")]
            Male,
            [Display(Description = "Женщина")]
            [Description("Женщина")]
            Female
        }
    
}

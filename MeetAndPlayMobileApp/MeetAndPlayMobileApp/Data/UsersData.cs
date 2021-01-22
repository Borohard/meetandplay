using MeetAndPlayMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MeetAndPlayMobileApp.Data
{
    
    public static class UsersData
    {
        public static ObservableCollection<User> Users { get; private set; }

        static UsersData()
        {
            Users = new ObservableCollection<User>();

            Users.Add(new User { 
            FirstName = "Алина",LastName = "Василенко",
                AboutUser = "Всем привет, я студентка Урфу, живу на ЖБИ, все друзья работают, а я пока что учусь, поэтому у меня много свободного времени,буду рада поиграть  в различные настолки",
                HelloMessege = "Привет , я хорошо знаю правила , хотела бы поиграть",
                    UserGames = "Дженга,Манчкин, Твистер, Алиес",Gender = Enums.Gender.Female,BirthDate = new DateTime(1999, 3, 6),FreeTime = "Каждый день после 7",GameLevel = Enums.GameLevel.Middle,UserEmail = "vasssilenko@Gmail", UserSocialNetworks = "https://vk.com/id2348765",
                UserPhoneNumber = "89000515151",UserAvatar = "Alina.jpg"          
            });

            Users.Add(new User
            {
                FirstName = "Александр",
                LastName = "Нохрин",
                AboutUser = "Всем привет, у меня дома много настолок, но я рабочий человек, поэтому могу играть только по выходным, живу на Уралмаше, могу встретиться на нейтральной стороне, а также с радостью приглашаю к себе",
                HelloMessege = "Привет , я хорошо знаю правила , хотела бы поиграть",
                UserGames = "Манчикин, За бортом",
                Gender = Enums.Gender.Male,
                BirthDate = new DateTime(1999, 1, 6),
                FreeTime = "выходные",
                GameLevel = Enums.GameLevel.Middle,
                UserEmail = "  sania@mai.ru",
                UserSocialNetworks = "https://vk.com/id169186641",
                UserPhoneNumber = "8986345789",
                UserAvatar = "Sanya.jpg"
            });

            Users.Add(new User
            {
                FirstName = "Павел",
                LastName = "Бородин",
                AboutUser = "Я студент, люблю играть в разные настольные игры. Открыт для новых знакомств, живу в общаге, поэтому встречусь на нейтральном месте. У меня есть только дженга, но умею играть манчкин, за бортом",
                HelloMessege = "Привет , я хорошо знаю правила , хотела бы поиграть",
                UserGames = "Дженга,Манчкин, Твистер, Алиес",
                Gender = Enums.Gender.Male,
                BirthDate = new DateTime(1999, 8, 31),
                FreeTime = "Каждый день после 7",
                GameLevel = Enums.GameLevel.Middle,
                UserEmail = "borodin@mai.ru",
                UserSocialNetworks = "https://vk.com/id169186641",
                UserPhoneNumber = "8986345890",
                UserAvatar = "Pasha.jpg"
            });


        }
    }
}

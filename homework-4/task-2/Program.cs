using System;
using System.Collections.Generic;

namespace task2
{
    class MainClass
    {
        public static string GetCityName(int code)
        {
            if (code >= 0 && code <= 43)
            {
                return "Благоевград";
            }
            else if (code >= 44 && code <= 93)
            {
                return "Бургас";
            }
            else if (code >= 94 && code <= 139)
            {
                return "Варна";
            }
            else if (code >= 140 && code <= 169)
            {
                return "Велико Търново";
            }
            else if (code >= 170 && code <= 183)
            {
                return "Видин";
            }
            else if (code >= 184 && code <= 217)
            {
                return "Враца";
            }
            else if (code >= 218 && code <= 233)
            {
                return "Габрово";
            }
            else if (code >= 234 && code <= 281)
            {
                return "Кърджали";
            }
            else if (code >= 282 && code <= 301)
            {
                return "Кюстендил";
            }
            else if (code >= 302 && code <= 319)
            {
                return "Ловеч";
            }
            else if (code >= 320 && code <= 341)
            {
                return "Монтана";
            }
            else if (code >= 342 && code <= 377)
            {
                return "Пазарджик";
            }
            else if (code >= 378 && code <= 395)
            {
                return "Перник";
            }
            else if (code >= 396 && code <= 435)
            {
                return "Плевен";
            }
            else if (code >= 436 && code <= 501)
            {
                return "Пловдив";
            }
            else if (code >= 502 && code <= 527)
            {
                return "Разград";
            }
            else if (code >= 528 && code <= 555)
            {
                return "Русе";
            }
            else if (code >= 556 && code <= 575)
            {
                return "Силистра";
            }
            else if (code >= 576 && code <= 601)
            {
                return "Сливен";
            }
            else if (code >= 602 && code <= 623)
            {
                return "Смолян";
            }
            else if (code >= 624 && code <= 721)
            {
                return "София - град";
            }
            else if (code >= 722 && code <= 751)
            {
                return "София - окръг";
            }
            else if (code >= 752 && code <= 789)
            {
                return "Стара Загора";
            }
            else if (code >= 790 && code <= 821)
            {
                return "Добрич (Толбухин)";
            }
            else if (code >= 822 && code <= 843)
            {
                return "Търговище";
            }
            else if (code >= 844 && code <= 871)
            {
                return "Хасково";
            }
            else if (code >= 872 && code <= 903)
            {
                return "Шумен";
            }
            else if (code >= 904 && code <= 925)
            {
                return "Ямбол";
            }
            else if (code >= 926 && code <= 999)
            {
                return "Друг/Неизвестен";
            }
            else
            {
                return "Unknown";
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter EGN: ");
            String egn = Console.ReadLine();
            int cityCode = int.Parse(egn.Substring(6, 3));
            int genderDigit = int.Parse(egn.Substring(8, 1));

            string gender = (genderDigit % 2 == 0) ? "man" : "woman";

            string city = GetCityName(cityCode);

            Console.WriteLine(gender);
            Console.WriteLine(city);
        }
    }
}

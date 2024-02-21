using System;

namespace task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter EGN: ");
            String egn = Console.ReadLine();
            int year = int.Parse(egn.Substring(0, 2));
            int month = int.Parse(egn.Substring(2, 2));
            int day = int.Parse(egn.Substring(4, 2));

            if (month > 40)
            {
                month -= 40;
            }
            else if (month > 20)
            {
                month -= 20;
            }

            if (year < 19)
            {
                year += 2000;
            }
            else
            {
                year += 1900;
            }

            DateTime birthDate = new DateTime(year, month, day);
            DateTime currentDate = new DateTime(2019, 12, 31);
            int age = currentDate.Year - birthDate.Year;
            if (currentDate < birthDate.AddYears(age))
            {
                age--;
            }

            if (age >= 18)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("juvenile");
            }
        }
    }
}

using System;

namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the EGN: ");
            string egn = Console.ReadLine();

            int year = int.Parse(egn.Substring(0, 2));
            int month = int.Parse(egn.Substring(2, 2));
            int day = int.Parse(egn.Substring(4, 2));

            if (month > 40)
            {
                month -= 40;
                year += 2000;
            }
            else if (month > 20)
            {
                month -= 20;
                year += 1800;
            }
            else
            {
                year += 1900;
            }
            DateTime birthDate = new DateTime(year, month, day);
            string dayOfWeek = birthDate.DayOfWeek.ToString();

            Console.WriteLine($"{birthDate:dd.MM.yyyy}");
            Console.WriteLine(dayOfWeek);
        }
    }
}

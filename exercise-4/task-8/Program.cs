using System;

namespace task8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the day: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Enter the month: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter the year: ");
            int year = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);
            Console.WriteLine("Day of the week: " + date.ToString("dddd"));


        }
    }
}

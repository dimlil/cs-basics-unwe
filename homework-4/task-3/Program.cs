using System;

namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the date and time (format: dd.M.yyyy HH:mm:ss):");
            string input = Console.ReadLine();
            DateTime dateTime = DateTime.ParseExact(input, "dd.M.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine("Year: " + dateTime.Year);
            Console.WriteLine("Month: " + dateTime.Month);
            Console.WriteLine("Day: " + dateTime.Day);
            Console.WriteLine("Hour: " + dateTime.Hour);
            Console.WriteLine("Minutes: " + dateTime.Minute);
            Console.WriteLine("Seconds: " + dateTime.Second);
        }
    }
}

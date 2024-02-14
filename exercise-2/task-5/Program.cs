using System;

namespace task5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Celsius = ");
            double Celsius = double.Parse(Console.ReadLine());
            double Kelvin = (double) Celsius + 273.15;
            double Fahrenheit = (double) (Celsius * 18/10) + 32;
            Console.WriteLine("Result: Fahrenheit = {0}, Kelvin = {1}",Fahrenheit, Kelvin);
        }
    }
}
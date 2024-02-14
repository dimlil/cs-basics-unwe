using System;

namespace task8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("r = ");
            double r = double.Parse(Console.ReadLine());
            double S = 4 * 3.14 * Math.Pow(r, 2);
            double V = (0.75 * 3.14 * Math.Pow(r, 3));
            Console.WriteLine("Result: S = {0}, V = {1}", S, V);
        }
    }
}

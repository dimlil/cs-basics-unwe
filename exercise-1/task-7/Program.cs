using System;

namespace task7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("r = ");
            double r = double.Parse(Console.ReadLine());
            double P = 3.14 * r * 2;
            double S = 3.14 * Math.Pow(r,2);
            Console.WriteLine("Result: P = {0}, S = {1}",P,S);
        }
    }
}

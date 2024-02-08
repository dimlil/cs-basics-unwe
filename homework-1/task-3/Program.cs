using System;

namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double P = a + b + c;
            double S = (a * b) / 2;

            Console.WriteLine("Result: P={0}, S={1}",P,S);
        }
    }
}

using System;

namespace task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("number_1 = ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("number_2 = ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("number_3 = ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("number_4 = ");
            int num4 = int.Parse(Console.ReadLine());
            int sum = num1 + num2 + num3 + num4;
            double avr = (double) sum / 4;
            Console.WriteLine("Result: average value = " + avr);
        }
    }
}

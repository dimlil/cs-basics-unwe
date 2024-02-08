using System;

namespace task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(input, 2);
            Console.WriteLine("Result: " + binary);
        }
    }
}

using System;

namespace task9
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("number = ");
            int number = int.Parse(Console.ReadLine());
            if (number % 5 == 0)
            {
                Console.WriteLine("IS divisible");
            }
            else
            {
                Console.WriteLine("is NOT divisible");
            }
        }
    }
}

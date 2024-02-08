using System;

namespace task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("symbol: ");
            var input = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(input, out _) || double.TryParse(input, out _))
            {
                Console.WriteLine("Result: number");
            }
            else
            {
                if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u")
                {
                    Console.WriteLine("Result: vowel");
                }
                else
                {
                    Console.WriteLine("Result: other");
                }
            }
        }
    }
}

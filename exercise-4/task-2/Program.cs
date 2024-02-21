using System;

namespace task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String[] words = input.Split(' ');
            Console.WriteLine(words.Length);
        }
    }
}

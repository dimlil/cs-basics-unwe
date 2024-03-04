using System;
using System.Collections.Generic;
namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String text = Console.ReadLine();
            char[] splitBy = new char[] { ' ', '.', ',', '!', '?' };
            string[] words = text.Split(splitBy);
            Queue<String> queue = new Queue<string>();
            foreach (var item in words)
            {
                queue.Enqueue(item);
            }
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}

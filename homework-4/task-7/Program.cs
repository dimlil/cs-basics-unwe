using System;

namespace task7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter word: ");
            String word = Console.ReadLine();
            Console.Write("Enter sentence: ");
            String sentence = Console.ReadLine();

            String[] words = sentence.Split(' ');
            int counter = 0;
            foreach (var item in words)
            {
                if (item.Contains(word))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}

using System;

namespace task6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter search word: ");
            String searchWord = Console.ReadLine();
            Console.Write("Enter sentence: ");
            String sentence = Console.ReadLine();
            Console.Write("Enter new word: ");
            String newWord = Console.ReadLine();

            sentence = sentence.Replace(searchWord, newWord);
            Console.WriteLine("Result: " + sentence);
        }
    }
}

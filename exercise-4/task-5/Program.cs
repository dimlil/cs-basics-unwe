using System;

namespace task5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter sentence: ");
            String input = Console.ReadLine();
            int vowelsCount = 0;
            int consonantsCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'o' || input[i] == 'e' || input[i] == 'i' || input[i] == 'u')
                {
                    vowelsCount++;
                }
                else
                {
                    if (input[i] != ' ')
                    {
                        consonantsCount++;
                    }
                }
            }
            Console.WriteLine($"Vowels: {vowelsCount}, consonants: {consonantsCount}");
        }
    }
}

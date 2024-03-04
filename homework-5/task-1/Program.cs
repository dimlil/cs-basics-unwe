using System;
using System.Collections.Generic;

namespace task1
{
    class MainClass
    {
        public static Dictionary<string, string> synonymous = new Dictionary<string, string>();
        public static Dictionary<string, string> interpretive = new Dictionary<string, string>();
        public static Dictionary<string, string> translations = new Dictionary<string, string>();


        public static void add()
        {
            Console.Write("New word: ");
            String word = Console.ReadLine();
            if (!synonymous.ContainsKey(word))
            {
                Console.Write("Synonym: ");
                String synonymousWord = Console.ReadLine();
                synonymous[word] = synonymousWord;
                Console.WriteLine("The word has been added in synonyms ");
            }
            else
            {
                Console.WriteLine("The word exists in synonyms ");
            }

            if (!interpretive.ContainsKey(word))
            {
                Console.Write("Description: ");
                String interpretiveWord = Console.ReadLine();
                interpretive[word] = interpretiveWord;
                Console.WriteLine("The word has been added in dictionary");
            }
            else
            {
                Console.WriteLine("The word exists in dictionary");
            }

            if (!translations.ContainsKey(word))
            {
                Console.Write("Translation: ");
                String translationsWord = Console.ReadLine();
                translations[word] = translationsWord;
                Console.WriteLine("The word has been added in translations");
            }
            else
            {
                Console.WriteLine("The word exists in translations");
            }
        }
        public static void search()
        {
            Console.Write("Search for: ");
            String word = Console.ReadLine();
            if (synonymous.ContainsKey(word))
            {
                Console.WriteLine("Synonyms: " + synonymous[word]);
            }
            if (interpretive.ContainsKey(word))
            {
                Console.WriteLine("Description: " + interpretive[word]);
            }
            if (translations.ContainsKey(word))
            {
                Console.WriteLine("Translation: " + translations[word]);
            }
        }
        public static void remove()
        {
            Console.Write("Delete word: ");
            String word = Console.ReadLine();
            if (synonymous.ContainsKey(word))
            {
                synonymous.Remove(word);
            }
            else
            {
                Console.WriteLine("The word does not exist in synonyms");
            }
            if (interpretive.ContainsKey(word))
            {
                interpretive.Remove(word);
            }
            else
            {
                Console.WriteLine("The word does not exist in dictionary");
            }
            if (translations.ContainsKey(word))
            {
                translations.Remove(word);
            }
            else
            {
                Console.WriteLine("The word does not exist in translations");
            }
        }
        public static void getLenght()
        {
            Console.WriteLine("Words in synonyms: " + synonymous.Count);
            Console.WriteLine("Words in dictionary: " + interpretive.Count);
            Console.WriteLine("Words in translations: " + translations.Count);
        }
        public static void Main(string[] args)
        {
            Console.Write("Choose operation: ");
            int command = int.Parse(Console.ReadLine());
            while (command != 0)
            {
                switch (command)
                {
                    case 1:
                        add();
                        break;
                    case 2:
                        search();
                        break;
                    case 3:
                        remove();
                        break;
                    case 4:
                        getLenght();
                        break;
                    default:
                        break;
                }
                Console.Write("Choose: ");
                command = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Thank you");
        }
    }
}
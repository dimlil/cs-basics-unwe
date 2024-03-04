using System;
using System.Collections.Generic;

namespace task1
{
    class MainClass
    {
        private static List<string> books = new List<string>();
        public static void add()
        {
            String book = Console.ReadLine();
            books.Add(book);
        }
        public static void remove()
        {
            String book = Console.ReadLine();
           
            if (books.Contains(book))
            {
                books.Remove(book);
            }
            else
            {
                Console.WriteLine("The book does not exist");
            }
        }
        public static void alphaalphabetical()
        {
            List<string> booksCoppy = books;
            booksCoppy.Sort();
            foreach (var item in booksCoppy)
            {
                Console.WriteLine(item);
            }
        }
        public static void reverse()
        {
            List<string> booksCoppy = books;
            booksCoppy.Reverse();
            foreach (var item in booksCoppy)
            {
                Console.WriteLine(item);
            }
        }
        public static void Main(string[] args)
        {
            books.Add("Book1");
            books.Add("Book2");
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
                        remove();
                        break;
                    case 3:
                        alphaalphabetical();
                        break;
                    case 4:
                        reverse();
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

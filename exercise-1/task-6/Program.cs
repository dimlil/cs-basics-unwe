using System;

namespace task6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("letter_1 = ");
            String firstLetter = Console.ReadLine();
            Console.Write("letter_2 = ");
            String secondLetter = Console.ReadLine();
            Console.Write("letter_3 = ");
            String thirdLetter = Console.ReadLine();
            Console.WriteLine("{0}{1}{2}",thirdLetter,secondLetter,firstLetter);
        }
    }
}

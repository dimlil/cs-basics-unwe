using System;

namespace task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Sentence 1 = ");
            String input1 = Console.ReadLine();

            Console.Write("Sentence 2 = ");
            String input2 = Console.ReadLine();


            if (input1.Length==input2.Length)
            {
                int count = 0;
                for (int i = 0; i < input1.Length; i++)
                {
                    if (input1[i] != input2[i])
                    {
                        count++;
                    }
                }
                if (count > 0)
                {
                    Console.WriteLine($"Same length, but {count} different symbols");
                }
                else
                {
                    Console.WriteLine("Same length, same symbols.");
                }
            }
            else
            {
                Console.WriteLine("Different length");
            }
        }
    }
}

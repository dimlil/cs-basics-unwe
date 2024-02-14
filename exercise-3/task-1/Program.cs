using System;

namespace task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Number: ");
            int inputNum = int.Parse(Console.ReadLine());
            int[] multiplicationTable = new int[10];

            for (int i = 1; i < 11; i++)
            {
                multiplicationTable[i-1] = i * inputNum;
            }
            for (int i = 1; i < 11; i++)
            {
                if (i == 10)
                {
                    Console.Write($"{inputNum}*{i}={multiplicationTable[i - 1]}");
                    break;
                }
                Console.Write($"{inputNum}*{i}={multiplicationTable[i - 1]}, ");

            }
        }
    }
}

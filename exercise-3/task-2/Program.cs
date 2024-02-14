using System;

namespace task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number_{i+1}: ");
                int inputNum = int.Parse(Console.ReadLine());
                arr[i] = inputNum;
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 9)
                {
                    Console.Write($"number_{i+1} = {arr[i]}");
                    break;
                }
                Console.Write($"number_{i} = {arr[i]}, ");
            }
        }
    }
}

using System;

namespace task5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("length = ");
            int lenght = int.Parse(Console.ReadLine());
            int[] arr = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                Console.Write($"Element{i} = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = arr.Length; i > 0; i--)
            {
                if (i == 1)
                {
                    Console.Write(arr[i-1]);
                    break;
                }
                Console.Write($"{arr[i - 1]}, ");
            }
        }
    }
}

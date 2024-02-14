using System;
using System.Collections.Generic;
namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Number of elements: ");
            int lenght = int.Parse(Console.ReadLine());
            int currentLength = 1;
            //int[] numbers = { 9, 6, 2, 7, 4, 7, 6, 6, 8, 4 };
            int[] numbers = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                Console.Write($"Element {i}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);
            List<int> sortedArr = new List<int>();
            for (int i = 0; i < numbers.Length-1; i++)
            {
                Boolean isExist = false;
                for (int j = 0; j < sortedArr.Count; j++)
                {
                    if (sortedArr[j] == numbers[i])
                    {
                        isExist = true;
                    }
                }
                if (isExist == false)
                {
                    sortedArr.Add(numbers[i]);
                }
            }
            int step = sortedArr[1] - sortedArr[0];
            for (int i = 0; i < sortedArr.Count; i++)
            {
                if (sortedArr[i + 1] - sortedArr[i] == step)
                {
                    currentLength++;
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < currentLength; i++)
            {
                Console.Write($"{sortedArr[i]} ");
            }
        }
    }
}
 
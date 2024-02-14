using System;

namespace task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Number of elements: ");
            int lenght = int.Parse(Console.ReadLine());
            int maxLength = 0;
            int currentLength = 1;
            int start = 0;
            int end = 0;
            int[] numbers = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                Console.Write($"Element {i}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        start = i - maxLength + 2;
                        end = i + 1;
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }

            Console.Write("The longest sequence of consecutive numbers is: ");
            for (int i = start; i <= end; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}

using System;

namespace task6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Length of an array: ");
            int lenght = int.Parse(Console.ReadLine());
            int[,] arr = new int[lenght, lenght];
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    Console.Write($"Element - [{i}],[{j}]: ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix is :");
            int sum = 0;
            for (int i = 0; i < lenght; i++)
            {
                sum += arr[i, i];
                for (int j = 0; j < lenght; j++)
                {
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("The Sum of the right Diagonal elements is: " + sum);
        }
    }
}

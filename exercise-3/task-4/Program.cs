using System;

namespace task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Length of Array1= ");
            int arr1Lenght = int.Parse(Console.ReadLine());
            int[] arr1 = new int[arr1Lenght];

            for (int i = 0; i < arr1Lenght; i++)
            {
                Console.Write($"Element{i} = ");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Length of Array2= ");
            int arr2Lenght = int.Parse(Console.ReadLine());

            int[] arr2 = new int[arr2Lenght];

            for (int i = 0; i < arr2Lenght; i++)
            {
                Console.Write($"Element{i} = ");
                arr2[i] = int.Parse(Console.ReadLine());
            }

            if (arr1Lenght == arr2Lenght)
            {
                Boolean isEqual = true;
                for (int i = 0; i < arr1Lenght; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        isEqual = false;
                    }
                }
                if (isEqual==true)
                {
                    Console.WriteLine("Arrays are equal, the lengths are equal");
                }
                else
                {
                    Console.WriteLine("Arrays are not equal, the lengths are equal");
                }
            }
            else
            {
                Console.WriteLine("The lengths are not equal");
            }
        }
    }
}

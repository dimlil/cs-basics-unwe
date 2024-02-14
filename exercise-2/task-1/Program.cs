using System;

namespace task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            int subtract = num1 - num2;
            int multiply = num1 * num2;
            int dividing = num1 / num2;
            Console.WriteLine("Result: adding = {0}, subtracting = {1}, multiplying = {2}, dividing = {3}",sum,subtract,multiply,dividing);
        }
    }
}

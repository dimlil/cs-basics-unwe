using System;

namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("z = ");
            int z = int.Parse(Console.ReadLine());

            int firstEquation = (x + y) * z;
            int secondSubEq1 = x * y;
            int secondSubEq2 = y * z;
            int secondEquation = secondSubEq1 + secondSubEq2;

            Console.WriteLine("Result: (x+y)*z = {0}, x*y + y*z = {1} + {2} = {3}",firstEquation,secondSubEq1,secondSubEq2,secondEquation);
        }
    }
}

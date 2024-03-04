using System;
using System.Collections.Generic;

namespace task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String text = Console.ReadLine();
            char[] splitBy = new char[] { ' ', '.', ',', '!', '?' };
            string[] words = text.Split(splitBy);
            Stack<string> stack = new Stack<string>();
            foreach (var item in words)
            {
                stack.Push(item);
            }
            String result = "";
            while (stack.Count > 0)
            {
                result += stack.Pop() + " ";
            }
            Console.WriteLine(result);
        }
    }
}

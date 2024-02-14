using System;

namespace task4
{
    class MainClass
    {
        public static int diggetsSum(int number)
        {
            int sum = 0, reminder;
            while (number > 0)
            {
                reminder = number % 10;
                sum = sum + reminder;
                number = number / 10;
            }
            return sum;
        }
        public static String reverseNumber(char[] number)
        {
            String result = "";
            for (int i = number.Length-1; i >= 0; i--)
            {
                result += number[i];
            }
            return result;
        }
        public static String reverseFirstAndLast(char[] number)
        {
            String result = number[3].ToString() + number[0].ToString() + number[1].ToString() + number[2].ToString();
            return result;
        }
        public static String reverseMiddle(char[] number)
        {
            String result = number[0].ToString() + number[2].ToString() + number[1].ToString() + number[3].ToString();

            return result;
        }
        public static void Main(string[] args)
        {
            Console.Write("number = ");
            int number = int.Parse(Console.ReadLine());
            int sum = diggetsSum(number);
            var diggets = number.ToString().ToCharArray();

            String reversedNum = reverseNumber(diggets);
            String reversedFirstAndLast = reverseFirstAndLast(diggets);
            String reversedMiddle = reverseMiddle(diggets);

            Console.WriteLine("Result: {0},{1}, {2}, {3}", sum, reversedNum, reversedFirstAndLast, reversedMiddle);

        }
    }
}
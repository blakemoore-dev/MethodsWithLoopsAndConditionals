using System;
using System.Text;

namespace MethodsWithLoopsAndConditionals
{
    public class Methods
    {
        // LukeWarm Section:
        public static void _1000ThroughNegative1000()
        {
            Console.WriteLine("All whole numbers 1000 through -1000 are:");
            for (int i = 1000; i >= -1000; i--)
                Console.WriteLine(i);
        }
        public static void _3Through99By3()
        {
            Console.WriteLine("All multiples of 3 from 3 through 999 are:");
            for (int i = 3; i <= 999; i+=3)
                Console.WriteLine(i);
        }
        public static void NumbersAreEqual()
        {
            static void NumsAreEqal(int x, int y)
            {
                Console.WriteLine(x == y ? "Numbers are equal!" : "Numbers are NOT equal!");

            }
            Console.WriteLine("Please input two whole numbers to determine if they are equivalent.");
            Console.Write("Number one:    ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number two:    ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            NumsAreEqal(num1, num2);
        }
        public static void EvenOrOdd()
        {
            static void IsEvenOrOdd(int x)
            {
                Console.WriteLine(x%2 == 0 ? "Number is EVEN" : "Number is ODD");
            }
            Console.Write("Please input a whole number to determine if it is EVEN or ODD:    ");
            var input = Convert.ToInt32(Console.ReadLine());
            IsEvenOrOdd(input);
        }
        public static void PositiveOrNegative()
        {
            Console.Write("Please input a number to determine if it is POSITIVE or NEGATIVE:    ");
            var input = Convert.ToInt32(Console.ReadLine());
            static void IsPosOrNeg(int x)
            {
                if (x == 0)
                {
                    Console.WriteLine("UNSIGNED!");
                }
                else if (x > 0)
                {
                    Console.WriteLine($"{x} is POSITIVE");
                }
                else
                    Console.WriteLine($"{x} is NEGATIVE");
            }
            IsPosOrNeg(input);
        }
        public static void VotingAge()
        {
            Console.Write("Are you old enough to vote? Please enter your age:    ");
            //var age = Convert.ToInt32(Console.ReadLine());
            //var age = int.Parse(Console.ReadLine());
            var age = int.TryParse(Console.ReadLine(), out int result);
            Console.WriteLine(result >= 18 ? "Step into the polling booth, please." : "Sorry try again next election season.");

        }
        // Heatin Up Section:
        public static void IsInRange()
        {
            Console.Write("Enter a number to determine if it is within the range of -10 to 10:    ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number >= -10 && number <= 10 ? $"Number {number} is in range." : $"Number {number} is NOT in range.");
        }
        public static void MultiplicationTableOfNumber()
        {
            Console.Write("Input a number to show its multiplication table from 1 to 12:    ");
            var input = Convert.ToInt32(Console.ReadLine());
            var table = new StringBuilder();
            table.AppendLine();
            table.AppendLine("/---------------------------------\\");
            table.AppendLine($"|  Multiplication table of {input} is:  |");
            table.AppendLine("\\---------------------------------/");
            table.AppendLine();
            table.AppendLine($" 1: {input}");
            table.AppendLine($" 2: {input*2}");
            table.AppendLine($" 3: {input*3}");
            table.AppendLine($" 4: {input*4}");
            table.AppendLine($" 5: {input*5}");
            table.AppendLine($" 6: {input*6}");
            table.AppendLine($" 7: {input*7}");
            table.AppendLine($" 8: {input*8}");
            table.AppendLine($" 9: {input*9}");
            table.AppendLine($"10: {input*10}");
            table.AppendLine($"11: {input*11}");
            table.AppendLine($"12: {input*12}");

            Console.WriteLine(table);
        }
    }
}

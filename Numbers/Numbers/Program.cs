using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5; // A int is a datatype containing a whole number
            num++; // num++ will add one to the int value
            num--; // num-- will subtract one to the int value

            Console.WriteLine(2 + 2); // plus calculations
            Console.WriteLine(4 * 7); // multiplication
            Console.WriteLine(36 / 3); // division
            Console.WriteLine(5 % 2); // remainder of division
            Console.WriteLine((2 + 4) * 5); // multiplication with parenthesis
            Console.WriteLine(2 + 3 * 7);
            Console.WriteLine(5 / 2); // if there is only whole number it will be printed with only as whole numbers
            Console.WriteLine(5.0 / 2); // if one of the numbers or more have decimals it will be printed in decimals

            Console.WriteLine(Math.Abs (-40)); // Math.Abs will print the absolute value
            Console.WriteLine(Math.Pow (2 , 3)); // Math.Pow square the numbers
            Console.WriteLine(Math.Sqrt(36)); // Math.Sqrt will print the square root of the number
            Console.WriteLine(Math.Max(7, 32)); // Math.Max will print out the biggest number
            Console.WriteLine(Math.Min(7, 32)); // Math.Min will print out the smallest number
            Console.WriteLine(Math.Round(4.3)); // Math.Round will round the number and print it



        }
    }
}

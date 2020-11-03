using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is Calculator 1.0");
            Console.WriteLine("Valid operators \"+\" \"-\" \"*\" \"/\" \"Square\" \"SquareRoot\" \"Max\" \"Min\" \"Round\"");
            Console.Write("Enter a number : ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a operator : ");
            string op = Console.ReadLine();

            Console.Write("Enter a second number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }



            else if(op == "-")
            {
                Console.WriteLine(num1 - num2);
            }

            else if(op == "*")
            {
                Console.WriteLine(num1 * num2);
            }

            else if(op == "/")
            {
                Console.WriteLine(num1 / num2);
            }

            else if (op == "Square")
            {
                Console.WriteLine(Math.Pow(num1, num2));
            }

            else if (op == "SquareRoot")
            {
                Console.WriteLine(Math.Sqrt(num1));
            }

            else if (op == "Max")
            {
                Console.WriteLine(Math.Max(num1, num2));
            }

            else if (op == "Min")
            {
                Console.WriteLine(Math.Min(num1, num2));
            }

            else if (op == "Round")
            {
                Console.WriteLine(Math.Round(num1));
            }



            else
            {
                Console.WriteLine("Error: Invalid operator");         
            }
           
            Console.ReadLine();
        }
    }
}

using System;

namespace Positive_or_Negative
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputNum1;
            double Num1;

            string InputNum2;
            double Num2;


            Console.Write("Enter the first number you want to multiply : ");
            InputNum1 = Console.ReadLine();
            Num1 = Convert.ToDouble(InputNum1);

            Console.Write("Enter the second number you want to multiply : ");
            InputNum2 = Console.ReadLine();
            Num2 = Convert.ToDouble(InputNum2);

            if (Num1 < 0 && Num2 < 0)
            {
                Console.WriteLine("The result is positive.");
            }

            else if (Num1 > 0 && Num2 > 0)
            {
                Console.WriteLine("The result is positive.");
            }

            else
            {
                Console.WriteLine("The result is negative.");
            }
            Console.ReadKey();

        }
    }
}

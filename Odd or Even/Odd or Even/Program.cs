using System;
using System.Transactions;

namespace Odd_or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;
            string InputNumber;
            

            Console.WriteLine("This is the odd or even 1.0");
            Console.ReadLine();
            Console.Write("Enter a whole number : ");

            InputNumber = Console.ReadLine();
            Number = Convert.ToInt32(InputNumber);

            if (Number % 2 > 0)
            {
                Console.WriteLine("The number is odd.");
            }

            else
            {
                Console.WriteLine("The number is even.");
            }

            Console.ReadKey();
            
        }
    }
}

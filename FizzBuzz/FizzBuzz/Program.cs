using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 1;


            do
            {

                if (Number % 3 == 0 && Number % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (Number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else if (Number % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
           
                else
                {
                    Console.WriteLine(Number);
                }

                Number++;

            } while (Number < 101);

            Console.ReadKey();
        }
    }
}

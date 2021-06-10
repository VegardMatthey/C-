using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            string userInput = Console.ReadLine();
            ulong userNumber = Convert.ToUInt64(userInput);

            ulong[] fibo = new ulong[userNumber + 1];
            Fibonacci(fibo);

            Console.WriteLine(fibo[userNumber]);

            Console.ReadKey();

        }
    
        static ulong[] Fibonacci(ulong[] fibo)
        {
      

            fibo[0] = 0;
            fibo[1] = 1;


            for (int index = 0; index + 2 < fibo.Length; index++)
            {
                ulong nextNum = fibo[index] + fibo[index + 1];
                fibo[index + 2] = nextNum;              
            }
            
            return fibo;



        }
    
    
    }
}

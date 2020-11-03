using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            string userInput = Console.ReadLine();
            int userNumber = Convert.ToInt32(userInput);

            int[] fibo = new int[userNumber + 1];
            Fibonacci(fibo);

            Console.WriteLine(fibo[userNumber]);

            Console.ReadKey();

        }
    
        static int[] Fibonacci(int[] fibo)
        {
      

            fibo[0] = 0;
            fibo[1] = 1;
            

            for (int index = 0; index + 2 < fibo.Length; index++)
            {
                int nextNum = fibo[index] + fibo[index + 1];
                fibo[index + 2] = nextNum;              
            }
            
            return fibo;



        }
    
    
    }
}

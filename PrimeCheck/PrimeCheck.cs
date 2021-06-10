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

            int[] primeNumbers = new int[index];

            primeNumbers[0] = 2;
            primeNumbers[1] = 3;
            primeNumbers[2] = 5;
            primeNumbers[3] = 7;
            primeNumbers[4] = 11;
            primeNumbers[5] = 13;
            primeNumbers[6] = 17;
            primeNumbers[7] = 19;
            primeNumbers[8] = 23;
            primeNumbers[9] = 29;
            primeNumbers[10] = 31;
            primeNumbers[11] = 37;
            primeNumbers[12] = 41;
            primeNumbers[13] = 43;
            primeNumbers[14] = 47;
            primeNumbers[15] = 53;
            primeNumbers[16] = 59;
            primeNumbers[17] = 61;
            primeNumbers[18] = 67;
            primeNumbers[19] = 71;
            primeNumbers[20] = 73;
        

            Console.ReadKey();

        }
    
        private int CheckForPrime(int userNumber)
        {   
            for(int index = 0; index > userNumber; index++)
            {
                int sqrtUserNum = Math.Sqrt(userNumber);
                
                if(primeNumbers[index] % index > 0 && sqrtUserNum + 2 > primeNumbers[index])
                {
                    Console.WriteLine(index); 
                }
            }

        }
    
    
    }
}
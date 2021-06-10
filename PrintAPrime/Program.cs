using System;
using static 
System.Math;

namespace PrintAPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many primes to print : ");
            int primesToPrint = Convert.ToInt32(Console.ReadLine());
            int[] primes = new int[primesToPrint];       
            primes[0] = 2;
            primes[1] = 3;
            if(primesToPrint < 1)
            {
                Console.WriteLine("Well then...");
            }
                
            Console.WriteLine(primes[0]);
            Console.WriteLine(primes[1]);

            

            

            for (int primesFound = 2; primesFound < primesToPrint; primesFound++)
            {
                //find a prime and add to array here.
                for(int possiblePrime = primes[primesFound - 1] + 2; ;possiblePrime += 2)
                {
                    if(PrimeCheck(possiblePrime))
                    {
                        primes[primesFound] = possiblePrime;
                    }

                    
                }
                
            }

        }
    
        static bool PrimeCheck(int possiblePrime)
        {
            //Check if the number is a prime here.
            
            
            for(int index = 3; index < Sqrt(possiblePrime); index += 2)
            {
                bool isPrime = true;
                 if(possiblePrime % index == 0)
                {
                    return false;
                }
            }

            return true;
        }
    


    
    
    }
}

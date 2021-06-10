using System;
using System.Numerics;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            bool isPrime = n == 2;
            if(n > 2)
            {
                isPrime = true;
                BigInteger rn = (BigInteger)Math.Pow(Math.E, BigInteger.Log(n) / 2);

                for(BigInteger i = 3; i < rn; i += 2)
                {
                    if(n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
          
            }
             Console.WriteLine(isPrime);
        }
    }
}

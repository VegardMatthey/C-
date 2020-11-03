using System;

namespace Gangulatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number :");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Answer: " + num1 * num2);

            Console.ReadLine();

            Console.WriteLine("Skriv inn et tall :");
            double tallEn = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Skriv enda et tall");
            double tallTo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Svar: " +tallEn * tallTo);

            Console.ReadLine();

            
        }
    }
}

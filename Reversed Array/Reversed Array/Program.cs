
using System;
using System.CodeDom.Compiler;

namespace Reversed_Array
{
    class Program
    {
       
        static void Main(string[] args)
        {

            int[] numbers = GenerateNumbers();
            PrintNumbers(numbers);
            Reverse(numbers);
            PrintNumbers(numbers);

            Console.ReadKey();
        }

        static int[] GenerateNumbers()
        {
            Console.Write("Enter amount of numbers : ");
            string inputAmountOfNumbers = Console.ReadLine();
            int amountOfNumbers = Convert.ToInt32(inputAmountOfNumbers);

            Random numberGenerator = new Random();
            int[] generatedNumbers = new int[amountOfNumbers];

            for (int index = 0; index < amountOfNumbers; index++)
            {               
                int number = numberGenerator.Next(1, 100);           
                generatedNumbers[index] = number;
            }
           
            return generatedNumbers; 

        }

        static void Reverse(int[] numbers)
        {
            
            for (int index = 0; index < numbers.Length / 2; index++)
            {
                int temp = numbers[index];
                numbers[index] = numbers[numbers.Length - index - 1];
                numbers[numbers.Length - index - 1] = temp;
            }
            
        }

        static void PrintNumbers(int[] numbers)
        {
            foreach(int number in numbers)
            {
                Console.Write(number+" ");          
            }
            Console.WriteLine();
        }

        
        
    }
}

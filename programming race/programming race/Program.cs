using System;

namespace programming_race
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            
            string inputnum = Console.ReadLine();
            int num = Convert.ToInt32(inputnum);

            for (int index = 0; index + 1 < num; index++)
            {
                Console.Write(index + ", ");
            }
            Console.ReadKey();
        }
    }
}

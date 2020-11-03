using System;

namespace HabitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int HabitPoints = 0;

            Console.WriteLine("Have you read?");
            Console.ReadLine();
            
            if (Console.ReadLine() == "yes")
            {
                HabitPoints++;
                Console.WriteLine("You currently have " + HabitPoints + "habitpoints");
            }
        }
    }
}

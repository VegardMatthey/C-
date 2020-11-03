using System;

namespace If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your gender");
            string userGender = Console.ReadLine();
            bool isTall = true;
            bool isMale = true;
            

            if (isMale && isTall) // && = and  || = or   ! = not
            {
                Console.WriteLine("You're a tall male");
            }
            else if(isMale && !isTall)
            {
                Console.WriteLine("You're a short male");
            }
            else if (isTall && !isMale)
            {
                Console.WriteLine("You're a tall female");
            }
            else
            {
                Console.WriteLine("You're a short female");
            }
            
            
        }
    }
}

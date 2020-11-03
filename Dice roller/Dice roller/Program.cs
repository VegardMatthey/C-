using System;

namespace Dice_roller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to roll some dice?");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("Enter the amount of dice you want to roll : ");
                string inputAmountOfDice = Console.ReadLine();

                int amountOfDice = Convert.ToInt32(inputAmountOfDice);
                Random dice = new Random();

                for (int index = 0; index < amountOfDice; index++)
                {
                    int dieRoll = dice.Next(6) + 1;
                    Console.WriteLine(dieRoll);

                }


                Console.ReadKey();

            }

            else if (answer == "no")
            {
                Console.WriteLine("Why did run this program if you don't want to use it?");
                Console.ReadKey();
                return;
            }

            else
            {
                Console.WriteLine("Answer yes or no god damnit!");
            }

            
        }
    }
}

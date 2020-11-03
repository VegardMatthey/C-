using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Math_Trainer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGenerator = new Random();
            

            string Retry;
            string Operator;

            






            Console.WriteLine("This is the MathTrainer 1.0");
            Console.WriteLine("It includes addition, subtraction, multiplication, divition or a mix.");
            Console.Write("\nEnter what you want to practice : ");

            Operator = Console.ReadLine();

            Console.Write("Enter the minimum for the first number : ");
            string InputMinimumNum1 = Console.ReadLine();

            Console.Write("Enter the maksimum for the first number : ");
            string InputMaksimumNum1 = Console.ReadLine();


            Console.Write("Enter the minimum for the second number : ");
            string InputMinimumNum2 = Console.ReadLine();

            Console.Write("Enter the maksimum for the second number : ");
            string InputMaksimumNum2 = Console.ReadLine();


            int MinimumNum1 = Convert.ToInt32(InputMinimumNum1);
            int MaksimumNum1 = Convert.ToInt32(InputMaksimumNum1);

            int MinimumNum2 = Convert.ToInt32(InputMinimumNum2);
            int MaksimumNum2 = Convert.ToInt32(InputMaksimumNum2);

            int Num1 = numberGenerator.Next(MinimumNum1, MaksimumNum1);
            int Num2 = numberGenerator.Next(MinimumNum2, MaksimumNum2);
            string answer;
            int NumberAnswer;

            /* Func<double, double, double> func = null;
            if (Operator == "+")
            {
                func = (x, y) => x + y;
            }
            else if (Operator == "*")
            {
                func = (x, y) => x * y;
            }

            if (func == null)
                  return;
            double res = func(2, 3);*/

            if (Operator == "+")
            {
                do
                {

                    Console.Write("\n" + Num1 + Operator + Num2 + " = ");
                    answer = Console.ReadLine();
                    NumberAnswer = Convert.ToInt32(answer);



                    if (Num1 + Num2 == NumberAnswer)
                    {
                        Console.WriteLine("\nYour answer was correct! \nDo you want to try again?");
                        Retry = Console.ReadLine();
                    }


                    else
                    {
                        Console.WriteLine("\nYour answer was incorrect. \nDo you want to try again?");
                        Retry = Console.ReadLine();
                    }

                    Console.ReadKey();

                    Num1 = numberGenerator.Next(MinimumNum1, MaksimumNum1);
                    Num2 = numberGenerator.Next(MinimumNum2, MaksimumNum2);

                } while (Retry == "yes");
            }


            if (Operator == "-")
            {
                do
                {

                    Console.Write("\n" + Num1 + Operator + Num2 + " = ");
                    answer = Console.ReadLine();
                    NumberAnswer = Convert.ToInt32(answer);



                    if (Num1 - Num2 == NumberAnswer)
                    {
                        Console.WriteLine("\nYour answer was correct! \nDo you want to try again?");
                        Retry = Console.ReadLine();
                    }


                    else
                    {
                        Console.WriteLine("\nYour answer was incorrect. \nDo you want to try again?");
                        Retry = Console.ReadLine();
                    }

                    Console.ReadKey();

                    Num1 = numberGenerator.Next(MinimumNum1, MaksimumNum1);
                    Num2 = numberGenerator.Next(MinimumNum2, MaksimumNum2);


                } while (Retry == "yes");


            }

            if (Operator == "*")
            {
                do
                {

                    Console.Write("\n" + Num1 + Operator + Num2 + " = ");
                    answer = Console.ReadLine();
                    NumberAnswer = Convert.ToInt32(answer);



                    if (Num1 * Num2 == NumberAnswer)
                    {
                        Console.WriteLine("\nYour answer was correct! \nDo you want to try again?");
                        Retry = Console.ReadLine();
                    }


                    else
                    {
                        Console.WriteLine("\nYour answer was incorrect. \nDo you want to try again?");
                        Retry = Console.ReadLine();
                    }

                    Console.ReadKey();

                    Num1 = numberGenerator.Next(MinimumNum1, MaksimumNum1);
                    Num2 = numberGenerator.Next(MinimumNum2, MaksimumNum2);

                } while (Retry == "yes");

            
            }

            if (Operator == "/")
            {
                do
                {

                    if (Num1 != Num2 && Num1 % Num2 == 0)
                    {

                        Console.Write("\n" + Num1 + Operator + Num2 + " = ");
                        answer = Console.ReadLine();
                        NumberAnswer = Convert.ToInt32(answer);


                        if (Num1 / Num2 == NumberAnswer)
                        {
                            Console.WriteLine("Your answer was correct! \nDo you want to try again?");
                            Retry = Console.ReadLine();
                        }


                        else
                        {
                            Console.WriteLine("Your answer was incorrect. \nDo you want to try again?");
                            Retry = Console.ReadLine();
                        }

                    }

                    else
                    {                   
                        Retry = "yes";
                    }
                    

                    Num1 = numberGenerator.Next(MinimumNum1, MaksimumNum1);
                    Num2 = numberGenerator.Next(MinimumNum2, MaksimumNum2);


                } while (Retry == "yes");

            }

            else
            {
                Console.WriteLine("Error : invalid operator.");
            }
        
        
        }
    }
}

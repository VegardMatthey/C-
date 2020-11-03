using System;

namespace Calculator_V_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is the Calculator 2.0");
            Console.WriteLine("Valid operators \"+\" \"-\" \"*\" \"/\" \"square\" \"sqrt\" \"max\" \"min\" \"round\"");

          

            Console.WriteLine("\npi = " + Math.PI + " \ne = " + Math.E);
            


            double Num1;
            double Num2;
                

            Console.Write("\nEnter a number : ");
            string InputNum1 = Console.ReadLine();

            

            Num1 = Convert.ToDouble(InputNum1);

            



            Console.Write("Enter a operator : ");
            string Operator = Console.ReadLine();

         

            if (Operator == "round")
            {
                Console.WriteLine(Math.Round(Num1));
                Console.ReadKey();
                return;
            }

            if (Operator == "sqrt")
            {
                Console.WriteLine(Math.Sqrt(Num1));
                Console.ReadKey();
                return;
            }


        

            Console.Write("Enter another number : ");
            string InputNum2 = Console.ReadLine();

            Num2 = Convert.ToDouble(InputNum2);

           


            switch (Operator)
            {
                case "+":
                    Console.WriteLine(Num1 + Num2);
                    break;

                case "-":
                    Console.WriteLine(Num1 - Num2);
                    break;

                case "*":
                    Console.WriteLine(Num1 * Num2);
                    break;

                case "/":
                    Console.WriteLine(Num1 / Num2);
                    break;

                case "square":
                    Console.WriteLine(Math.Pow (Num1, Num2));
                    break;
         

                case "max":
                    Console.WriteLine(Math.Max(Num1, Num2));
                    break;

                case "min":
                    Console.WriteLine(Math.Min(Num1, Num2));
                    break;

                

            }


            Console.ReadKey();

        }
    
    }
}

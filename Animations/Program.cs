using System;


namespace Animations
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadingAnimation();

            Console.ReadKey();
        }

    
        static void SpinAnimation()
        {
            Console.Write("Enter the amount of rounds : ");
            int userRounds = Convert.ToInt32(Console.ReadLine());

            char[] chars = new char[4] {'|','|','-','\\'};

            for(int rounds = 0; rounds < userRounds * 2; rounds++)
            {
                
                Console.Write(chars[0]);
                Console.ReadKey();
                Console.Clear();

                

                Console.Write(chars[1]);
                Console.ReadKey();
                Console.Clear();

                

                Console.Write(chars[2]);
                Console.ReadKey();
                Console.Clear();

                

                Console.Write(chars[3]);
                Console.ReadKey();
                Console.Clear();

                

            }
            
        }

        static void LoadingAnimation()
        {
            string preset = "Loading";
            string[] dots = new string[3] {"." , ".." , "..."};

            Console.Write("Enter the amount of rounds : ");
            int userRounds = Convert.ToInt32(Console.ReadLine());

            for(int rounds = 0; rounds < userRounds; rounds++)
            {
                
                Console.Write(preset + dots[0]);
                Console.ReadKey();
                Console.Clear();
                

                Console.Write(preset + dots[1]);
                Console.ReadKey();
                Console.Clear();
                
                Console.Write(preset + dots[2]);
                Console.ReadKey();
                Console.Clear();
                

            }
        }
    
    }
}

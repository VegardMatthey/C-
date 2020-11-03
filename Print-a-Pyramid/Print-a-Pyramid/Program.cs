using System;
using System.Data;

namespace Print_a_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            int spacesleft = 4;
            int starsleft = 1;

            for (int row = 0; row < 5; row++)
            {
                for (int space = spacesleft; space > 0; space--)
                {
                    Console.Write(" ");
                    
                }

                for (int star = starsleft; star > 0 ; star--)
                {
                    Console.Write("*");

                      
                }


                Console.WriteLine();

                spacesleft--;
                starsleft++;
                starsleft++;
            
            }

            Console.ReadKey();
        
        
        }
    }
}

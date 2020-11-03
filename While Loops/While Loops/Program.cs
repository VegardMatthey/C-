using System;

namespace While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 6;

            do    // the do while lopp checks if index < 5 after the code has been executed once
            {
                Console.WriteLine(index);
                index++;                 
            } while (index < 5);




        }
    }
}

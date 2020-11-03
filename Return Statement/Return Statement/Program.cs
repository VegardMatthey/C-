using System;

namespace Return_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the number you want to cube : ");
            
            int cubedNumber = (cube (5));
            
            Console.WriteLine(cubedNumber);

            Console.ReadLine();

        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
            

    }
}
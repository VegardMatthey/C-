using System;

namespace Copy_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            

            int[] OriginalArray = new int[10] { 3, 14, 32, 63, 85, -17, 0, 8, 47, 13 };
            int[] CopyArray = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int index = 0; index < OriginalArray.Length; index++)
            {
                CopyArray[index] = OriginalArray[index];
            }


            Console.WriteLine(OriginalArray[9]);
            Console.WriteLine(CopyArray[9]);

            Console.ReadKey();

           
        }
    }
}

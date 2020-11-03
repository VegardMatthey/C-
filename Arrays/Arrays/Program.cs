using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Luckynumber = {2, 3, 5, 7, 11, 13, 17}; // Array containing whole numbers  // index postion 2 = 0     3 = 1     5 = 2
            string[] family = new string[4];     // Array without values    
            family[0] = "Henrik";                // Adding a value to the array above
            family[1] = "Sunniva";
            family[2] = "Vegard";
            family[3] = "Thierry";
            family[4] = "Christine";




            Luckynumber[0] = 2 + 1;                        // Updating value
            Console.WriteLine(Luckynumber [0]); // the int value can be used by specifying the index value





            Console.ReadLine();
        }
    }
}

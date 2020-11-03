using System;
using System.Xml.Schema;

namespace Average_and_Minimum_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Numbers = new double[9] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

           
            double total = 0.0;
            

            double CurrentMinimum = Int32.MaxValue;

            foreach (double Number in Numbers)
            {
                if (Number < CurrentMinimum)
                {
                    CurrentMinimum = Number;
                }
            }

            foreach (double Number in Numbers)
            {
                total = Number + total;
            }

            double average = total / Numbers.Length;

            Console.WriteLine("The minimun value is = " + CurrentMinimum);
            Console.WriteLine("The average value is = " + average);

            Console.ReadKey();

        }
    }
}

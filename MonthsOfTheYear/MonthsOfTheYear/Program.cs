using System;

namespace MonthsOfTheYear
{
    class Program
    {
        enum MonthsOfTheYear { January = 1, February = 2, March = 3, April = 4, May = 5, June = 6, July = 7, August = 8, Septemeber = 9, October = 10, November = 11, December = 12 }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 12");

            string InputNum = Console.ReadLine();
            

            switch (InputNum)
            {
                case "1":
                    Console.WriteLine("It's " + MonthsOfTheYear.January + ".");
                    break;

                case "2":
                    Console.WriteLine("It's " + MonthsOfTheYear.February + ".");
                    break;

                case "3":
                    Console.WriteLine("It's " + MonthsOfTheYear.March + ".");
                    break;

                case "4":
                    Console.WriteLine("It's " + MonthsOfTheYear.April + ".");
                    break;

                case "5":
                    Console.WriteLine("It's " + MonthsOfTheYear.May + ".");
                    break;

                case "6":
                    Console.WriteLine("It's " + MonthsOfTheYear.June + ".");
                    break;

                case "7":
                    Console.WriteLine("It's " + MonthsOfTheYear.July + ".");
                    break;

                case "8":
                    Console.WriteLine("It's " + MonthsOfTheYear.August + ".");
                    break;

                case "9":
                    Console.WriteLine("It's " + MonthsOfTheYear.Septemeber + ".");
                    break;

                case "10":
                    Console.WriteLine("It's " + MonthsOfTheYear.October + ".");
                    break;

                case "11":
                    Console.WriteLine("It's " + MonthsOfTheYear.November + ".");
                    break;

                case "12":
                    Console.WriteLine("It's " + MonthsOfTheYear.December + ".");
                    break;


                default:
                    Console.WriteLine("The nuber wasn't between 1 and 12");
                    break;
            }

        }
    }
}

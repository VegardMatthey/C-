using System;

namespace Switch_Statements
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetDay(6));


        }
    
        static string GetDay (int dayNum) // The day will be called by number
        {
            string dayName;
            
            switch (dayNum) // a switch statement will check which case will return true
            {
                case 0:
                    dayName = "Monday";
                    break;    // the break tells that if it returns true then stop. if there's multiple cases which are true the break should not be there

                case 1:
                    dayName = "Tuesday";
                    break;

                case 2:
                    dayName = "Wednesday";
                    break;

                case 3:
                    dayName = "Thursday";
                    break;

                case 4:
                    dayName = "Friday";
                    break;

                case 5:
                    dayName = "Saturday";
                    break;

                case 6:
                    dayName = "Sunday";
                    break;

                default:  // deafult will return true if no case does
                    dayName = "Ivalid day number";
                    break;
            }






            return dayName;
        }
    
    }
}

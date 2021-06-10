using System;
using System.Text;
using System.Text.RegularExpressions;

namespace RegExTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex rx = new Regex(@"^i", RegexOptions.IgnoreCase);
            string input = "island";
            string suffix = "ay";
            //char[] vowels = {a,e,i,o,u};

            if(Regex.IsMatch(input, @"^[aeiou]"))
            {
                Console.Write(input + suffix);
            }

            else if(Regex.IsMatch(input, @"[aeiou]")
            {
                var res = Regex.Replace(input, @"^([^aeiou]+)(.*)$", @"$2$1");
            }

            


            
            
        }
    }
}

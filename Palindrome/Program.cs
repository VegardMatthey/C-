using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word : ");
            string input = Console.ReadLine();
            Console.WriteLine(CheckPalindrome(input));
        }

        static bool CheckPalindrome(string originalString)
        {
            string reversedString = string.Empty;

            for(int i = originalString.Length - 1; i > -1; i--)
            {
                reversedString += originalString[i];
            }

            if(reversedString == originalString)
            {
                return true;
            }

            return false;
        }
    }
}

using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Hello!" + "\nHow are you?";

            Console.WriteLine("1\n2"); // \n will be used to go to a new line
            Console.WriteLine("\"Hello!\" How are you?"); // \" will allow a " in a string
            Console.WriteLine(phrase); // the string called phrase will print
            Console.WriteLine(phrase.ToUpper()); // phrase.ToUpper will make the string to all upper case letters
            Console.WriteLine(phrase.ToLower());  // phrase.ToLower will make the string to all lower case letters
            Console.WriteLine(phrase.Length); // phrase.Length will count the amount of characters in the string
            Console.WriteLine(phrase.Contains("Hello!")); // phrase.Contains will return true if both strings are the same
            Console.WriteLine(phrase[0]); // phrase[0] will print the first character of the string
            Console.WriteLine(phrase.IndexOf("Hello!")); // phrase.IndexOf will find the first character in the string and the IndexPosition
            Console.WriteLine(phrase.IndexOf('l')); // phrase.IndexOf will find the IndexPosition of the first place the character occurs
            Console.WriteLine(phrase.IndexOf('x')); // phrase.IndexOf will print -1 if the charcter does not occur
            Console.WriteLine(phrase.Substring(7,3)); //phrase.Substring will print a part of a string starting from a IndexPosition with specified amount of characters

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "John";
            int characterAge;
            characterAge = 35;

            Console.WriteLine("Once upon a time there was a man " + characterName);
            Console.WriteLine("He was " +characterAge+ " years old" );
            Console.WriteLine("He didn't like the name " + characterName);
            Console.WriteLine("So he changed it to Mike");

            characterName = "Mike";

            Console.WriteLine(characterName+ " did not like the age of " +characterAge+ " either");

            characterAge = 35 + 1;

            Console.WriteLine("Luckily " +characterName+ " just turned " +characterAge+ " years old ");
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}

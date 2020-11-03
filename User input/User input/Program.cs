using System;

namespace User_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv inn navet ditt : ");
            string navn = Console.ReadLine();
            Console.Write("Skriv inn alderen din : ");
            string alder = Console.ReadLine();
            Console.WriteLine("Heter du " + navn + " og er du " + alder + " år gammel?");
            Console.ReadLine();

            Console.Write("Enter your name : ");            
            string name = Console.ReadLine();
            Console.Write("Enter your name : ");
            string age = Console.ReadLine();
            Console.WriteLine("Is your name " + name + " and are you " + age + " years old?");
            Console.ReadLine();

            


        }
    }
}

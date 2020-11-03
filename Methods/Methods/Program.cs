using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            SayHi("Tom", 23); // Calling the method



            Console.ReadLine();

        }
            
        static void SayHi(string name, int age) // Method
        {
            Console.WriteLine("Hello " + name + "You are " + age + "years old");

        }
    }




}

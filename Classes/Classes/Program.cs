using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball b1 = new Ball();
            b1.Throw();
            Console.WriteLine(b1.Points());
            
        } 
    }
}

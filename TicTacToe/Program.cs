using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tic tac toe!");
            Console.WriteLine("   |   |   " +  "---+---+---" + "   |   |   " + "---+---+---" + "   |   |   ");
            Player1();

        }
    
        public enum State
        {
            Empty,
            X,
            O
              
        }
    
    
    }
}

using System;

namespace TicTacToe
{
    public class Player
    {
        private string inputNum;
        private int position;

        public int GetPositon(int Position)
        {
           Console.Write("Enter a number : ");
           string InputNum = Console.ReadLine();
           int Position = Convert.ToInt32(inputNum);
           Console.WriteLine(position);
        }
    
        
    
    
    
    
    }
}

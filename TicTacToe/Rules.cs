using System;

namespace TicTacToe
{
    class Rules
    {
        public int  issueIndex;
        private bool isNumValid;
        private bool isPositonVacant;
        private bool hasPlayerWon;

        

        public NumberValdiation(bool isNumValid)
        {
            if(Player1.GetPosition() < 1 || Player1.GetPosition() > 9)
            {
                Console.WriteLine("Invalid number.");
                issueIndex++;
                return isNumValid = false;
            } 
            else 
            {
                return isNumValid = true;
            }             
        }
    
        public PositionValdiation(bool isPositionValid)
        {
            if()
            {
                Console.WriteLine("Vacant Position.");
                issueIndex++;
                return isPositionValid = false;
            } 
            else 
            {
                return isNumPosition = true;
            }             
        }

        public HasPlayerWon(bool hasPlayerWon)
        {
            if()
            {
                
            } 
            else 
            {
                
            }             
        }

    
    
    
    }
}
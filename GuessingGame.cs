using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_7GuessingGame
{
    class GuessingGame
    {
        // PRIVATE INSTANCE VARIABLES
        private Dictionary<string, object> GGString; // TODO: is object the most appropriate here?
        private int randomNumber;
        private Random r;

        // CONSTRUCTOR
        public GuessingGame()
        {
            // initialize variables
            r = new Random();
            randomNumber = 0;
            GGString = new Dictionary<string,object>();

            // insert Dictionary values
            GGString.Add("startGame", "Start the Game");
            GGString.Add("failMessage", "SORRY, GAME OVER");
            GGString.Add("winMessage", "CONGRATULATIONS! YOU WIN!");
            GGString.Add("infMessage", "Number provided is less than the number picked by the program... Please try again");
            GGString.Add("supMessage", "Number provided is greater than the number picked by the program... Please try again");
            GGString.Add("playAgainMessage", "Would you like to play again?");
            GGString.Add("score", 100);
            GGString.Add("lives", 10);
        }

        // PUBLIC METHODS
        // resets the game to initial state
        public void StartGame()
        {
            // reset score and lives
            // choose a new random number
            randomNumber = r.Next(1, 101);            
        }       
        
        public void Miss()
        {
            // decrement score and lives
        }

        // Method compares value to random number and returns int based on result
        public int CheckGuess(int value)
        {
            if (randomNumber < value) {
                this.Miss();
                return -1;
            } else if (randomNumber > value) {
                this.Miss();
                return 1;
            } else
                return 0;
        }
    }
}

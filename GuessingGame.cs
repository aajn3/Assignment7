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
        private int randomNumber, score, lives;
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

            //grabbing the values of lives and score from the dictionary
            score = Convert.ToInt32(GGString["score"]);
            lives = Convert.ToInt32(GGString["lives"]);

        }

        // PUBLIC METHODS
        // resets the game to initial state
        public void StartGame()
        {
            //reseting the values of score and lives to original values
            GGString["score"] = 100;
            GGString["lives"] = 10;
            // choose a new random number
            randomNumber = r.Next(1, 101);            
        }       
        
        public string Miss(int value)
        {
            //decrementing the lives and score
            score -= 10;
            lives -= 1;
            GGString["score"] = score;
            GGString["lives"] = lives;
            string message ="message"; 

            int guessResult = value; 

            if (guessResult == -1) {		        
                
                // turn cell yellow, display infMessage
                message = GGString["infMessage"].ToString();

            } else if (guessResult==1) {		        
                //Miss();
                // turn cell red, display supMessage
               message= GGString["supMessage"].ToString();
            }
            return message; 
        }

        // Method compares value to random number and returns int based on result
        public int CheckGuess(int guessValue)
        {
            //if the guessed value is less than the random num 
            if (randomNumber > guessValue) {
                //this.Miss();
                return -1;
            }
            //if the guessed value is greater than the random num
            else if (randomNumber < guessValue)
            {
                //this.Miss();
                return 1;
            } else
                return 0;
        }
    }
}

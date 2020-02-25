using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            //generate a random number
            Random rand = new Random();
            //generate a random number that has a range of just two numbers (0 or 1)
            int randomNumber = rand.Next(0, 2);
            //output the number
            Console.WriteLine(randomNumber);
            //prompt the user to pick heads or tails
            Console.WriteLine("Enter Heads or Tails. >>");
            //create variable as a sequence of characters for the user's response
            string usersGuessAsString = Console.ReadLine();

            //create variable as an integer for the user's response
            int usersGuess;
            //create variable as an integer that won't change for heads or tails
            const int HEADS_VALUE = 0;
            const int TAILS_VALUE = 1;

            //use an if statement to set the user's response equal to the numerical value for heads/tails
            if (usersGuessAsString == "Heads")
            {
                usersGuess = HEADS_VALUE;
            }
            else if (usersGuessAsString == "Tails")
            {
                usersGuess = TAILS_VALUE;
            }
            else
            {
                Console.WriteLine("Invalid entry: Please try again later.");
                //press a key to close out the program
                Console.ReadKey();
                //return the usersGuess to previous methods
                return;
            }

            //use another if statement to output whether or not the user was correct
            if (usersGuess == randomNumber)
            {
                Console.WriteLine($"Congrats, {usersGuessAsString} was right!");
            }
            else
            {
                if (usersGuess == 0)
                {
                    Console.WriteLine($"Sorry, Tails was the correct answer and you guessed {usersGuessAsString} :(");
                }
                else
                {
                    Console.WriteLine($"Sorry, Heads was the correct answer and you guessed {usersGuessAsString} :(");
                }
            }
            //prevent the app from closing until we press a key
            Console.ReadKey();
        }
    }
}

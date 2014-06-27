using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess_that_number
{
    class Program
    {
        static void Main(string[] args)
        {
            //user interface
            Console.WriteLine("would you venture a guess at my number?");
            Console.WriteLine();
            
            GameFunction();
            //asking user to play again
            Console.WriteLine("care to play again?");
            string answer = Console.ReadLine();
            string lower = answer.ToLower();
            if (lower == "yes" || lower == "y")
            {
                GameFunction();
            }

            else Console.WriteLine("Very well then.");
        }

        static void GameFunction()
        {
            Console.WriteLine("I am thinking of a number between 1 and 100.");
            Console.WriteLine();

            int countGuess = 0;
            //generating a random number between 1-100
            Random randomNumberGenerator = new Random();
            int randomNumber = randomNumberGenerator.Next(1, 101);

            Console.WriteLine("Please enter your guess.");
            int intImput = 0;

            while (intImput != randomNumber)
            {
                //user enters guesses here
                string NewImput = Console.ReadLine();
                countGuess++;
                intImput = Convert.ToInt32(NewImput);

                if (intImput > randomNumber)
                {
                    Console.WriteLine("Your guess was too high.");
                }

                else if (intImput < randomNumber)
                {
                    Console.WriteLine("Your guess was too low.");
                }
            }

            Console.WriteLine(intImput + " " + "was correct, congratulations.");
            Console.WriteLine();
            //counting the number of guesses until correct answer
            Console.WriteLine("Your number of guesses: " + countGuess);
            Console.WriteLine();
            Console.ReadKey();
        }

    }
}

using System;

// Namespace

namespace NumberGuesser2
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {

            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Zack Hendrix";
            string appPlace = "Zacks PC";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2} built on {3}", appName, appVersion, appAuthor, appPlace);

            // Reset Text Color
            Console.ResetColor();

            // Ask USers Name
            Console.WriteLine("What is your Name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play a game..." ,inputName);

            while (true) 

            
            // int correctNumber = 7;

            // Create a new random object
            Random random = new Random();


            // Init correct number
            int correctNumber = Random.Next(1, 10);

            // Init guess var
            int guess = 0;


            // Ask User for number
            Console.WriteLine("Guess a number between 1 and 10");


            // while guess is not correct
            while(guess != correctNumber)
            {
                // Get user Input
                string input = Console.ReadLine();

                // Make sure its a number
                if (!int.TryParse(input, out guess))
                {
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Tell user its not a number
                    Console.WriteLine("Please enter an actual number");

                    // Reset Text Color
                    Console.ResetColor();

                    // Keep going
                    continue;


                }

                // Cast to int and put in guess
                guess = Int32.Parse(input);

                // Match guess to correct number
                if (guess != correctNumber)
                {

                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Tell user its the wrong number
                    Console.WriteLine("Wrong Number, please try again" );

                    // Reset Text Color
                    Console.ResetColor();
                }

            }

            // Output Success message
            // Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Tell user its the right number
            Console.WriteLine("You are correct");

            // Reset Text Color
            Console.ResetColor();

            // Ask to play again
            Console.WriteLine("Play Again? [Y or N]");

            // Get answer
            string answer = Console.ReadLine() .ToUpper();

            if (answer == "Y") {
                continue;
            }

            else if (answer == "N")  {
                return;
            }

       



        }
    }
}

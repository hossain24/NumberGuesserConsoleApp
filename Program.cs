using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // string name = "Hossain Ahmad";
            // int age = 35;
            // string words = "years old";
            // Start Here //
            // Console.WriteLine("Hello " + name);
            // Console.WriteLine("{0} is {1} {2}",name,age,words);

            GetAppInfo();

            GreetUser();
            
            while (true) {
                // Init correct number
                //int correctNumber = 7;

                // Create a new random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    // Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Change text color
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        // Tell user it's not a number
                        Console.WriteLine("Pleasee enter an actual number");

                        // Reset text color
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
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        // Tell user it's the wrong number
                        Console.WriteLine("Wrong number, please try again");

                        // Reset text color
                        Console.ResetColor();
                    }
                }

                // Change text color
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                // Tell user it's the right number
                Console.WriteLine("You are CORRECT");

                //Reset text color
                Console.ResetColor();

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                } 
                else
                {
                    return;
                }

            }
           
        }

        static void GetAppInfo()
        {
            // Set App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Hossain Ahmad";

            // Change text color
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            // Write out app info
            Console.WriteLine("{0}: Version: {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }
    }
}

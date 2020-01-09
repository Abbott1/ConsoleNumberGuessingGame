using System;

// Namespace
namespace NumberGuessingGame
{
    // Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {

            GetAppInfo(); //Run GetAppInfo function to get app info 

            GreetUser(); // Ask for users name and greet user

            while (true)
            {

                //Create a new Random number
                Random random = new Random();

                //Init Correct Number
                int correctNumber = random.Next(1, 10);

                //Init guess Var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                //While guess Is Not Correct
                while (guess != correctNumber)
                {
                    //Get Users input
                    string input = Console.ReadLine();

                    //Make sure it is a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use a actual number");

                        //Keep going
                        continue;
                    }

                    //Cast To int And Put In guess
                    guess = Int32.Parse(input);

                    //Match guess To Correct Number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, Please try again");
                    }
                }

               
                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "Correct!!! You guessed it!");

                //Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N") {
                    return;
                }
                else {
                    return;
                }
            }
        }

        //Get and display app info
        static void GetAppInfo() {
            // Set App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Casey Abbott";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write Out App Info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset Text Color
            Console.ResetColor();
        }

        // Ask users name and greet
        static void GreetUser() {
            // Ask User Name 
            Console.WriteLine("What is your name?");

            //Get User Input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message 
        static void PrintColorMessage(ConsoleColor color, string message) {
            //Change text color
            Console.ForegroundColor = color;

            //Tell user its not a number
            Console.WriteLine(message);

            // Reset Text Color
            Console.ResetColor();
        }

    }
}
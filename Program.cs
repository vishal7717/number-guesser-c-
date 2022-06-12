using System;
//Namespace: number gusser
namespace NumberGusser
{
    // Main class
    class Program
    {
        // entry point method
        static void Main(string[] args)
        {   string userName="vishal";
            // string password="saurabh";

            // change text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello  "+userName+"!");

            // reset text color
            Console.ResetColor();

            // ask user for name

            Console.WriteLine("What is your name?");

            // get user input
            string inputName = Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.Blue;
                    
            Console.WriteLine("Hello {0}, let's paly a game", inputName);
                    Console.ResetColor();

            //init correct number
            int correctNumber = 7;

            // init guess var
            int guess = 0;

            // ask user for guess
            Console.WriteLine("Guess a number between 1 and 10");

            while(guess != correctNumber)
            {
                // get user input
                string input = Console.ReadLine();

                // parse to int
                guess = Int32.Parse(input);

                // check if guess is correct
                if (guess != correctNumber)
                {
                    // wrong number
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong number, please try again");
                    Console.ResetColor();
                }
            }
            // output success message
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You are correct");
            Console.ResetColor();
        }
    }
}

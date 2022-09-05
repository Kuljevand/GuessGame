using System;


//Name Space
namespace Playground
{

    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        { 
            GetAppInfo();


            GreetUser();

           
            while (true) //function part
            {

                //Create a new random object
                Random random = new Random();

                //init randome number
                int correctNumber = random.Next(1, 10);

                //innit guess var
                int guess = 0;

                //Ask user for a number
                Console.WriteLine("Guess number between 1 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    //get users input
                    string input = Console.ReadLine();


                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        //set error msg
                        PrintColorMessage(ConsoleColor.Red, "Please use a number!");
                        continue;
                    };

                    //cast to int and put in guess
                    guess = Int32.Parse(input);

                    //match guess to correct number
                    if (guess != correctNumber)
                    {
                        
                        PrintColorMessage(ConsoleColor.Red, "Not correct!");
                        

                    }

                };


                //Change text color and succes msg
                PrintColorMessage(ConsoleColor.Yellow, "Well Done!");

                
                //Ask to play again
                Console.WriteLine("Play Again? [Y or N]");
                
                //Get answer
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
            } //End of a function part
        } //End of a void string

        static void GetAppInfo()
        {
            //set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Dino";

            //Changing text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out 
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);


            //Just output color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();


            Console.WriteLine("Hello {0}, let's play a game..", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

       



    } //End of a class
} //End class block




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true)
            {
                Random random = new Random();
                int CorrectNumber = random.Next(1, 10);



                int Guess = 0;

                Console.Write("Guess a number between 1 and 10: ");

                while (Guess != CorrectNumber)
                {
                    string GuessInput = Console.ReadLine();

                    if (!int.TryParse(GuessInput, out Guess))
                    {
                        PrintColor(false, ConsoleColor.DarkRed, "Please enter an actual number: ");
                        continue;
                    }

                    Guess = Int32.Parse(GuessInput);

                    if (Guess != CorrectNumber)
                    {
                        PrintColor(false, ConsoleColor.DarkRed, "Wrong number!, please try again: ");
                    }
                }

                PrintColor(true, ConsoleColor.DarkYellow, "Congrats! you got this right, are you a mind reader? ");

                Console.Write("Play again? [Y or N]: ");
                string answer = Console.ReadLine().ToLower();

                if (answer == "y")
                {
                    continue;
                }
                break;

            }

        }

        static void GetAppInfo()
        {
            string AppName = "Number guesser";
            string AppVersion = "1.0.0";
            string AppAuthor = "dev-pengi";

            PrintColor(true, ConsoleColor.Green, "{0}: Version {1} by {2}", AppName, AppVersion, AppAuthor);
            //Console.WriteLine("{0}: Version {1} by {2}", AppName, AppVersion, AppAuthor);

        }

        static void GreetUser()
        {
            Console.Write("Enter is your name: ");

            string NameInput;
            NameInput = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game", NameInput);
        }

        static void PrintColor(bool line, ConsoleColor color, string format, params object[] args)
        {
            Console.ForegroundColor = color;
            if (line)
                Console.WriteLine(format, args);
            else
                Console.Write(format, args);
            Console.ResetColor();
        }

    }
}
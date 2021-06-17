using System;
using System.Text.RegularExpressions;

namespace Module1Assignment1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputRegex = "";
            string inputString = "";

            Console.WriteLine("The default regular expression checks for at least one digit.");

            while (true)
            {
                Console.Write("\nEnter a regular expression (or press ENTER to use the default): ");
                inputRegex = Console.ReadLine();
                if (inputRegex == "")
                    inputRegex = "[0-9]+";
                Console.Write("Enter some input: ");
                inputString = Console.ReadLine();
                bool isMatchFound = Regex.IsMatch(inputString, inputRegex);
                Console.WriteLine("{0} matches {1} ? {2}", inputString, inputRegex, isMatchFound);
                Console.Write("\nPress ESC to end or any key to try again.");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                    break;
            }
        }
    }
}
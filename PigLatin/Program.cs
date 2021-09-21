using System;
using System.Linq;

namespace PigLatin
{
    public class Program
    {
        static void Main(string[] args)
        {
            TranslateController TC = new TranslateController();

            bool goOn = true;
            while (goOn == true)
            {
            string userInput = GetInput("Please input a word or sentence to translate to Pig Latin");
            string translation = TC.GetWord(userInput);
            Console.WriteLine(translation);

                goOn = getContinue();
            }
        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }

        public static bool getContinue()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to translate something else?  (y/n)");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "y")
            {
                return true;
            }
            else if (answer.ToLower() == "n")
            {
                Console.WriteLine("Anksthay orfay ayingplay!");
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand your response, please try again...");
            }
            return getContinue();
        }
    }
}
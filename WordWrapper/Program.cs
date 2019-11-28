using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    public class WordWrapper
    {
        public static string Wrap(string text, int maxLineLength)
        {
            //Declare variables
            string outputText = text;
            int insertLocation = maxLineLength;
            int textLength = outputText.Length;

            //Create a loop that goes to desired character determined by maxLineLength unless it reaches end line


            //Determine if character is a space


            //If character is not a space then loop back until it reaches a space


            //If/when character is a space then insert line break
            while (insertLocation < textLength)
            {   
                outputText = outputText.Insert(insertLocation, "\n");
                insertLocation = insertLocation + maxLineLength;
                textLength = outputText.Length;
            }

            WriteLine(outputText);

            return outputText;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string userInput = "";
            int userDeclaredMaxLength = 0;
            
            //Ask for line length 
            WriteLine("Enter in desired page length in number of characters per line (must be a whole number higher than 0).");

            //Get desired page length
            while(userDeclaredMaxLength <= 0)
            {
                userInput = ReadLine();

                if (int.TryParse(userInput, out int number))
                {
                    userDeclaredMaxLength = Convert.ToInt32(userInput);
                    if(userDeclaredMaxLength <= 0)
                    {
                        Console.WriteLine($"{userInput} is not a whole number above 0, enter in a whole number.");
                    }
                }
                else
                {
                    Console.WriteLine($"{userInput} is not a whole number above 0, enter in a whole number higher than 0.");
                }
            }
            
            //Ask for text to be put in desired page length
            WriteLine("\nEnter the text you wish to fit the desired page length.");

            //Get text entered in
            userInput = ReadLine();

            //Pass desired length and text to Wrap function
            WordWrapper.Wrap(userInput, userDeclaredMaxLength);

            ReadKey();
        }
    }
}
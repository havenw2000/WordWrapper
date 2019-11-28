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
            
            //Create a loop that goes to desired character determined by maxLineLength unless it reaches end line

            //Determine if character is a space

            //If character is not a space then loop back until it reaches a space

            //If/when character is a space then insert line break


            return "";
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string userDeclaredText = "";
            int userDeclaredMaxLength = 0;
            
            //Ask for line length 
            WriteLine("How many characters long would you like your page length to be?");

            //Get desired page length
            userDeclaredMaxLength = Console.ReadLine();


            //Ask for text to be put in desired page length

            //Get text entered in

            //Pass desired length and text to Wrap function


            ReadKey();
        }
    }
}
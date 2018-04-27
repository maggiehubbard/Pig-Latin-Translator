using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {

            //declare variables
            string input;
            string output;
            string response = "y";

            //user prompts
            Console.WriteLine("Welcome to the Pig Latin Translator! \n");
            while (response == "y")
            {
                Console.Write("Enter a word to be translated: ");
                input = Console.ReadLine().ToLower();

                string firstLetter = input.Substring(0, 1); //goes to first letter of word, to see if it'a a vowel
                if (firstLetter == "a" || firstLetter == "i" || firstLetter == "e" || firstLetter == "o" || firstLetter == "u")
                {
                    output = input + "way";
                }
                else output = ToPigLatin(input);//if it's not a vowel, it uses the pig latin method to remove the first consanants

                Console.WriteLine("Translated: " + output);
                Console.WriteLine("Do you want to continue? (y/n)");
                response = Console.ReadLine().ToLower();
            }
            //PAUSE
            Console.WriteLine("\n\nPress any key to exit");
            Console.ReadKey();

        }
        static string ToPigLatin(string input)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' }; //creates a character array for vowels

            //try to compare the char array to string to locate the first vowel, use substring method to
            //remove 1st consants and place them at the end of the word + 'ay'
            for (int i = 0; i < input.Length; i++)
            {
                for (int v = 0; v < vowels.Length; v++)
                {
                    if (input[i] == vowels[v])
                    {
                        int vowelIndex = i; //this finds where the vowel begins
                        string consBeforeVowel = input.Substring(0, vowelIndex); //this is supposed to go from that found vowel to the end of the sentence
                        string restOfWord = input.Substring(vowelIndex, input.Length - 1);
                        restOfWord = restOfWord + consBeforeVowel + "ay";
                        return restOfWord;
                    }
                }
            }

            

            return "No vowels";
        }
    }
}

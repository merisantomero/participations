using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a variable as a sequence of characters that holds "value"
            string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            //show the user the above sentence
            Console.WriteLine(sentence);

            //ask the user for input on what word they want to look for in the above sentence
            Console.WriteLine("What word would you like to look for? >>");
            //create a variable as a sequence of characters for the user's response
            string word = Console.ReadLine();

            Console.WriteLine("What word would you like to change it to? >>");
            string replacement = Console.ReadLine();

            //if their word is in the sentence, replace all occurrences of it with its replacement and output the new sentence
            if (sentence.Contains(word))
            {
                string newsentence = sentence.Replace(word, replacement);
                Console.WriteLine(newsentence);
            }
            //if there word isn't in the sentence, output sorry and their replacement word in reverse order using a loop
            else
            {
                Console.WriteLine($"Sorry, I could not find your word, {word}.");
                for (int i = replacement.Length - 1; i >= 0; i--)
                {
                    Console.Write(replacement[i]);
                }
            }

            Console.ReadKey();
        }
    }
}

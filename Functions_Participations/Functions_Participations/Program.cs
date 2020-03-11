using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_Participations
{
    class Program
    {
        static void Main(string[] args)
        {
            whichParticipation();
            Console.ReadKey();
        }
        static void whichParticipation()
        {
            Console.WriteLine("Would you like to run StringManipulation, Collections, or both?");
            string choice = Console.ReadLine().ToLower();
            if (choice == "stringmanipulation")
            {
                StringManipulation();
            }
            else if (choice == "collections")
            {
                Collections();
            }
            else
            {
                StringManipulation();
                Collections();
            }
            Console.ReadKey();
        }
        static void StringManipulation()
        {
            string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(sentence);
            Console.WriteLine("What word would you like to look for? >>");
            string word = Console.ReadLine();
            Console.WriteLine("What word would you like to change it to? >>");
            string replacement = Console.ReadLine();
            if (sentence.Contains(word))
            {
                string newsentence = sentence.Replace(word, replacement);
                Console.WriteLine(newsentence);
            }
            else
            {
                Console.WriteLine($"Sorry, I could not find your word, {word}.");
                for (int i = replacement.Length - 1; i >= 0; i--)
                {
                    Console.Write(replacement[i]);
                }
            }
        }
        static void Collections()
        {
            List<double> examGrades = new List<double>();
            string answer;
            do
            {
                Console.WriteLine("Enter your exam grade. >>");
                double grade = Convert.ToDouble(Console.ReadLine());
                examGrades.Add(grade);
                Console.WriteLine("Do you have another exam score, yes or no? >>");
                answer = Console.ReadLine();
            } while (answer == "yes");
            int exams = examGrades.Count;
            double sum = 0;
            double max = 0;
            double min = 100;
            for (int i = 0; i < exams; i++)
            {
                sum = sum + examGrades[i];
                if (examGrades[i] > max)
                {
                    max = examGrades[i];
                }
                if (examGrades[i] < min)
                {
                    min = examGrades[i];
                }
            }
            double avg = sum / exams;
            Console.WriteLine($"Your maximum exam score is {max}.");
            Console.WriteLine($"Your minimum exam score is {min}.");
            Console.WriteLine($"Your average exam score is {avg}.");
        }
    }
}

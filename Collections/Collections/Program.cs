using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a list for the user's exam grades
            List<double> examGrades = new List<double>();
            //create a variable as sequence of characters for the user's response to adding another grade
            string answer;

            //use a loop to keep adding grades to the list
            do
            {
                //ask the user to input their exam grade
                Console.WriteLine("Enter your exam grade. >>");
                //create a variable changing the user's response from a string to a real number
                double grade = Convert.ToDouble(Console.ReadLine());
                //add the exam grade to the list
                examGrades.Add(grade);

                Console.WriteLine("Do you have another exam score, yes or no? >>");
                answer = Console.ReadLine();

            } while (answer == "yes");

            //create a variable as a number for the amount of grades the user inputs
            int exams = examGrades.Count;
            //create a variable as a real number starting at 0 for the sum and max and 100 for the min
            double sum = 0;
            double max = 0;
            double min = 100;

            //use a for loop to calculate the sum, max, and min
            for (int i = 0; i < exams; i++)
            {
                //set sum equal to all of the exam grades added together
                sum = sum + examGrades[i];
                //use an if statement to find the maximum score
                if (examGrades[i] > max)
                {
                    max = examGrades[i];
                }
                //use another if statement to find the minimum score
                if (examGrades[i] < min)
                {
                    min = examGrades[i];
                }
            }

            //create a variable as a real number for the avg equal to the sum divided by the number of grades inputted
            double avg = sum / exams;


            //output  the max, min, and avg
            Console.WriteLine($"Your maximum exam score is {max}.");
            Console.WriteLine($"Your minimum exam score is {min}.");
            Console.WriteLine($"Your average exam score is {avg}.");

            Console.ReadKey();
        }
    }
}

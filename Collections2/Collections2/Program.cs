using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            string[] courses = new string[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter your course name. >>");
                courses[i] = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter your course number. >>");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{namespace[i].ToUpper()} {numbers[i]}");
            }

            List<double> grades = new List<double>();
            string answer;

            do
            {
                Console.WriteLine("Enter your exam score. >>");
                grades.Add(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Do you have another exam grade to answer? y or n >>");
                answer = Console.ReadLine();
            } while (answer == "y");

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperInformation("Meri Santomero", "MIS-3013", "03/09/2020");

            Console.WriteLine("What type of calculation do you want to perform?");
            string calculation = Console.ReadLine().ToLower();
            Console.WriteLine("What is your first value?");
            double val1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your second value?");
            double val2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            if (calculation == "add")
            {
                result = val1 + val2;
                Console.WriteLine($"Your result is {result}.");
            }
            else if (calculation == "subtract")
            {
                result = val1 - val2;
                Console.WriteLine($"Your result is {result}.");
            }
            else if (calculation == "multiply")
            {
                result = val1 * val2;
                Console.WriteLine($"Your result is {result}.");
            }
            else if (calculation == "divide")
            {
                result = val1 / val2;
                Console.WriteLine($"Your result is {result}.");
            }
            else
            {
                Console.WriteLine("I'm sorry. That is not a valid calculation. Please try again using add, subtract, multiply, or divide.");
                Console.ReadKey();
            }

            Console.WriteLine("Would you like to perform a new calculation? yes or no");
            string answer = Console.ReadLine().ToLower();

            while (answer == "yes")
            {
                Console.WriteLine("Would you like to use the result of your previous calculation as the first value? yes or no");
                string useresult = Console.ReadLine().ToLower();
                if (useresult == "yes")
                {
                    val1 = result;
                    Console.WriteLine("What type of calculation do you want to perform?");
                    calculation = Console.ReadLine().ToLower();
                    Console.WriteLine("What is your second value?");
                    val2 = Convert.ToDouble(Console.ReadLine());

                    if (calculation == "add")
                    {
                        result = val1 + val2;
                        Console.WriteLine($"Your result is {result}.");
                    }
                    else if (calculation == "subtract")
                    {
                        result = val1 - val2;
                        Console.WriteLine($"Your result is {result}.");
                    }
                    else if (calculation == "multiply")
                    {
                        result = val1 * val2;
                        Console.WriteLine($"Your result is {result}.");
                    }
                    else if (calculation == "divide")
                    {
                        result = val1 / val2;
                        Console.WriteLine($"Your result is {result}.");
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry. That is not a valid calculation. Please try again using add, subtract, multiply, or divide.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("What type of calculation do you want to perform?");
                    calculation = Console.ReadLine().ToLower();
                    Console.WriteLine("What is your first value?");
                    val1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("What is your second value?");
                    val2 = Convert.ToDouble(Console.ReadLine());

                    if (calculation == "add")
                    {
                        result = val1 + val2;
                        Console.WriteLine($"Your result is {result}.");
                    }
                    else if (calculation == "subtract")
                    {
                        result = val1 - val2;
                        Console.WriteLine($"Your result is {result}.");
                    }
                    else if (calculation == "multiply")
                    {
                        result = val1 * val2;
                        Console.WriteLine($"Your result is {result}.");
                    }
                    else if (calculation == "divide")
                    {
                        result = val1 / val2;
                        Console.WriteLine($"Your result is {result}.");
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry. That is not a valid calculation. Please try again using add, subtract, multiply, or divide.");
                        Console.ReadKey();
                    }
                }
                Console.WriteLine("Would you like to perform a new calculation? yes or no");
                answer = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Thank you for using my service.");
            Console.ReadKey();
        }
        static void DeveloperInformation(string developerName, string className, string dateOfWriting)
        {
            Console.WriteLine($"{developerName} wrote this application for {className} on {dateOfWriting}.");
        }
    }
}

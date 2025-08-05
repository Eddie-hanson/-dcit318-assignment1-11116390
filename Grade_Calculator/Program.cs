using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your grade (0 - 100): ");
                var input = Console.ReadLine();
                int grade = int.Parse(input);

                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Please enter a number between 0 and 100.");
                }
                else if (grade >= 90)
                {
                    Console.WriteLine("You got an A");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("You got a B");
                }
                else if (grade >= 70)
                {
                    Console.WriteLine("You got a C");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("You got a D");
                }
                else
                {
                    Console.WriteLine("You got an F");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}

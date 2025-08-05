using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Type_Identifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter three sides of a triangle (or type 'exit' to quit):");

                Console.Write("Side A: ");
                string inputA = Console.ReadLine();
                if (inputA.ToLower() == "exit") break;

                Console.Write("Side B: ");
                string inputB = Console.ReadLine();
                if (inputB.ToLower() == "exit") break;

                Console.Write("Side C: ");
                string inputC = Console.ReadLine();
                if (inputC.ToLower() == "exit") break;

                try
                {
                    double a = double.Parse(inputA);
                    double b = double.Parse(inputB);
                    double c = double.Parse(inputC);

                    if (a <= 0 || b <= 0 || c <= 0)
                    {
                        Console.WriteLine("Side lengths must be positive numbers.");
                        continue;
                    }

                    // Triangle Inequality Check
                    if (a + b > c && a + c > b && b + c > a)
                    {
                        if (a == b && b == c)
                        {
                            Console.WriteLine("This is an Equilateral triangle.");
                        }
                        else if (a == b || a == c || b == c)
                        {
                            Console.WriteLine("This is an Isosceles triangle.");
                        }
                        else
                        {
                            Console.WriteLine("This is a Scalene triangle.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The entered sides do not form a valid triangle.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter valid numeric values.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }

                Console.WriteLine(); 
            }

            Console.WriteLine("Goodbye!");
        }
    }
}

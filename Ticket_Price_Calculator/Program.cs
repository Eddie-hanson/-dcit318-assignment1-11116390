using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Price_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your age (or type 'exit' to finish): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Thank you for using the Ticket Price Calculator!");
                    break;
                }

                try
                {
                    int age = int.Parse(input);

                    if (age < 0)
                    {
                        Console.WriteLine("Age cannot be negative. Please try again.");
                    }
                    else if (age <= 12 || age >= 65)
                    {
                        Console.WriteLine("Your ticket price is GHC7 (Discounted).");
                    }
                    else
                    {
                        Console.WriteLine("Your ticket price is GHC10.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number or type 'exit' to finish.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }

                Console.WriteLine(); 
            }
        }
    
}
    
}

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
            Console.WriteLine("Enter your grade: ");
            var input = Console.ReadLine();
            int grade = int.Parse(input);
            if (grade > 90)
            {
                Console.WriteLine("You got an A");
            }
            else if ( grade >= 80)
            {
                Console.WriteLine("You got a B");
            }
            else if ( grade >= 70)
            {
                Console.WriteLine("You got a C");
            }
            else if ( grade >= 60)
            {
                Console.WriteLine("You got a D");
            }

            else
            {
                Console.WriteLine("You failed the exam");
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber != secondNumber)
            {
                Console.WriteLine("The numbers " + firstNumber + " and " + secondNumber + " are not equal to each other.");
                    }
            else
            {
                Console.WriteLine("The numbers " + firstNumber + " and " + secondNumber + " are the same number.");
            }
        }
    }
}
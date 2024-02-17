using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class VariableModification
    {
        static void Main()
        {
            int choice;
            string input;
            Console.WriteLine("Enter your choice:");
            Console.WriteLine("1. Integer");
            Console.WriteLine("2. Double");
            Console.WriteLine("3. String");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter an integer: ");
                    int intInput = int.Parse(Console.ReadLine());
                    intInput++;
                    Console.WriteLine("Modified integer: {0}", intInput);
                    break;
                case 2:
                    Console.Write("Enter a double: ");
                    double doubleInput = double.Parse(Console.ReadLine());
                    doubleInput++;
                    Console.WriteLine("Modified double: {0}", doubleInput);
                    break;
                case 3:
                    Console.Write("Enter a string: ");
                    string stringInput = Console.ReadLine();
                    stringInput += "*";
                    Console.WriteLine("Modified string: {0}", stringInput);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string Name = "";
            Console.WriteLine("Please enter your name:");
            Name = Console.ReadLine();
            if (Name.Length > 10)
                Console.WriteLine("name must be within 10 characters");
            else
                Console.WriteLine("User name: {0}", Name);
            Console.ReadLine();
            

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */

            Console.WriteLine("Enter first number");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operator:");
            string op = Console.ReadLine();

            double result = 0;
            bool valid = true;
            switch (op)
            {
                case "+";
                    result = n1 + n2;
                    break;
                case "-";
                    result = n1 - n2;
                    break;
                case "*";
                    result = n1 * n2;
                    break;
                case "/";
                    result = n1 / n2;
                    break;
                default:
                    valid = false;
                    break;

            }
            if (valid) Console.WriteLine("Result is:" + result);
            else Console.WriteLine("Invalid operator!");
            Console.ReadLine();
        }
    }

}

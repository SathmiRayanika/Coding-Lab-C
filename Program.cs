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

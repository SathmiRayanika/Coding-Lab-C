using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quetion_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Test Data: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Expected Output:");
            if (num >= 0)
            {
                Console.WriteLine("{0} is a positive number.", num);
            }
            else
            {
                Console.WriteLine("{0} is a negative number", num);
            }

            Console.ReadLine();
        }
    }
}

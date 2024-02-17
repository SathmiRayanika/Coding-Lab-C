using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class SubsetSum
    {
        static void Main()
        {
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            bool found = false;
            for (int i = 1; i < 32; i++) 
            {
                int sum = 0;
                for (int j = 0; j < 5; j++)
                {
                    if ((i & (1 << j)) != 0)
                    {
                        sum += numbers[j];
                    }
                }
                if (sum == 0)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("There exists a subset that sums to 0.");
            }
            else
            {
                Console.WriteLine("No subset sums to 0.");
            }
            Console.ReadLine();
        }
    }
}
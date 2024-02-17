using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class ApplyBonusScores
    {
        static void Main()
        {
            Console.Write("Enter a digit (1-9): ");
            char digitChar = Console.ReadKey().KeyChar;

            int digit;
            if (int.TryParse(digitChar.ToString(), out digit))
            {
                switch (digit)
                {
                    case 1:
                    case 2:
                    case 3:
                        digit *= 10;
                        Console.WriteLine("New value with bonus: {0}", digit);
                        break;
                    case 4:
                    case 5:
                    case 6:
                        digit *= 100;
                        Console.WriteLine("New value with bonus: {0}", digit);
                        break;
                    case 7:
                    case 8:
                    case 9:
                        digit *= 1000;
                        Console.WriteLine("New value with bonus: {0}", digit);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            Console.ReadLine();
        }
    }
}
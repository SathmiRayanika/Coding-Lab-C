using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NumberToWords
    {
        static void Main()
        {
            int number;

            Console.Write("Enter a number between 0 and 999: ");
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0 || number > 999)
            {
                Console.WriteLine("Invalid input.Enter a number between 0 and 999.");
                Console.Write("Enter a number: ");
            }

            string spokenNumber = ConvertToWords(number);

            Console.WriteLine("The spoken number is: {0}", spokenNumber);
        }

        static string ConvertToWords(int number)
        {
            string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string[] hundreds = { "", "Hundred", "Two Hundred", "Three Hundred", "Four Hundred", "Five Hundred", "Six Hundred", "Seven Hundred", "Eight Hundred", "Nine Hundred" };

            if (number == 0)
            {
                return "Zero";
            }
            string result = "";

            int hundred = number / 100;
            if (hundred > 0)
            {
                result += hundreds[hundred] + " ";
            }

            number %= 100;
            if (number < 20)
            {
                result += ones[number] + " ";
            }
            else
            {
                int ten = number / 10;
                int one = number % 10;

                result += tens[ten] + " ";
                if (one > 0)
                {
                    result += ones[one] + " ";
                }
            }
            result = result.Trim();

            return result;
            Console.ReadLine();
        }
    }
}


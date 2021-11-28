// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryToDecimal
{
    class Program
    {

        static void Main(string[] args)
        {
            int reminder, decimalValue = 0, base1 = 1;
            // Ask user to input there Binary number.
            Console.Write("Please enter a binary number: ");
            // Convert user input from string to int.
            int userBinNum = int.Parse(Console.ReadLine());

            while (userBinNum > 0)
            {
                reminder = userBinNum % 10;
                userBinNum = userBinNum / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            Console.Write("Decimal Value : " + decimalValue);
        }
    }
}

// example user inputs 101. 101 % 10 = 10.1 reminder becomes 1 and userBinNum = 10.
// DecimalValue becomes 1 (reminder 1 * 1 base1)
// base1 (1) * 2 = 2 becomes base1

// userBinNum (10) % 10 = 1 and 0 reminder - reminder = 0 userBinNum = 1
// DecimalValue (1) 0 * 2 =0 plus Dv(1) = 1 decimalValue now = 1 still
// base1(2) * 2 = 4 new base1 value

// userBinNum (1) % 10 = 0.1 reminder = 1 and userBinNum = 0
// DecimalValue (1) += reminder(1) * base1(4) DecimalValue now = 5
// base1 (4) * 2 = 8 which is new base1 value. - userBinNum (0) is equal to 0 so while loop no longer runs.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Hex_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            long decimalFromHex = HexadecimalToDecimalConvert(hex);
            Console.WriteLine(decimalFromHex);
        }
            private static long HexadecimalToDecimalConvert(string hex)
        {
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            long decimalNumber = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                decimalNumber *= 16;
                int wight = Array.IndexOf(digits, hex[i]);
                decimalNumber += wight;
            }
            return decimalNumber;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine(); ;   
            var dec = 0;
            for (int i = 0; i < s.Length; i++)
            {
                
                if (s[s.Length - i - 1] == '0') continue;
                dec += (int)Math.Pow(2, i);

            }
            Console.WriteLine(dec);
        }
    }
}

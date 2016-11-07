using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfNumbers
{
    class Startup
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int counter = 1; counter <= N; counter++)
            {
                int num = 0;
                num = num + counter;
                for (int row = 0; row < N; row++)
                {
                    Console.Write("{0} ", row + num);
                }
                Console.WriteLine();
            }
        }
    }
}
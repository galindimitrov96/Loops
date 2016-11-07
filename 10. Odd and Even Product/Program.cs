using System;
using System.Numerics;

namespace OddAndEvenProduct
{
    class Startup
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger Odd = 1;
            BigInteger Even = 1;
            string input = Console.ReadLine();

            for (int i = 0; i < N; i++)
            {
                if (i % 2 != 0)
                {
                    Even *= int.Parse(input.Split(' ')[i]);
                }
                else
                {
                    Odd *= int.Parse(input.Split(' ')[i]);
                }
            }
            if (Odd == Even)
            {
                Console.WriteLine("yes {0}", Even);
            }
            else
            {
                Console.WriteLine("no {0} {1}", Odd, Even);
            }
        }
    }
}
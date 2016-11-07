using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.Calculate_Again_
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger sum = 1;
            for (int i = n; i > k ; i--)
            {
                sum =sum * i;
            }
            Console.WriteLine(sum);
        }
    }
}

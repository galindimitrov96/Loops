using System;
using System.Numerics;

class Calc3FactV2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger r = n - k;

        BigInteger factThree = 1;

        for (BigInteger i = k + 1; i <= n; i++)
        {
            BigInteger result = i / r;
            factThree *= result;
            r--;
        }

        Console.WriteLine(factThree);
    }
}
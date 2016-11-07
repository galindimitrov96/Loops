using System;

class Calculate
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        ulong factorial = 1;
        double sum = 1 + 1 / x;         //1.5
        for (ulong counter = 2; counter <= n; counter++)
        {
            factorial = factorial * counter;        //first loop = 2
            double pow = Math.Pow(x, counter);      // first loop = 4
            sum = sum + (factorial / pow);          //first loop = 1.75
        }
        Console.WriteLine("{0:F5}", sum);
    }
}


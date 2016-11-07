using System;

class MMSAofNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double number1 = double.Parse(Console.ReadLine());
        double min = number1;
        double max = number1;
        double sum = number1;
        double avg = number1;
        for (int i = 2; i <= n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            min = Math.Min(min, number);
            max = Math.Max(max, number);
            sum = sum + number;
            avg = sum / i;
        }
        Console.WriteLine("min={0:F2}", min);
        Console.WriteLine("max={0:F2}", max);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", avg);
    }
}
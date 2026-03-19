using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double s = 0;
        double denominator = 1.0;

        
        for (int numerator = 1; numerator <= 39; numerator += 2)
        {
            
            s += (double)numerator / denominator;

            
            denominator *= 2;
        }

        
        Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
    }
}
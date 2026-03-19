using System;
using System.Linq;

class Program
{
    static void Main()
    {
        
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) return;

        
        int[] values = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

        int A = values[0];
        int N = 0;
        int nextIndex = 1;

       
        while (nextIndex < values.Length)
        {
            int tempN = values[nextIndex];
            if (tempN > 0)
            {
                N = tempN;
                break;
            }
            nextIndex++;
        }

        
        int sum = 0;
        for (int i = 0; i < N; i++)
        {
            sum += (A + i);
        }

        
        Console.WriteLine(sum);
    }
}
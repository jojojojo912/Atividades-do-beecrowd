using System;

class Program
{
    static void Main(string[] args)
    {
        
        int jStart = 7;

        for (int i = 1; i <= 9; i += 2)
        {
            
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine($"I={i} J={jStart - k}");
            }

            
            jStart += 2;
        }
    }
}
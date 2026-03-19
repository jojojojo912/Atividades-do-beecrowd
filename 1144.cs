using System;

class Program
{
    static void Main()
    {
       
        string input = Console.ReadLine();
        
        if (!string.IsNullOrEmpty(input) && int.TryParse(input.Trim(), out int n))
        {
           
            for (long i = 1; i <= n; i++)
            {
                
                long square = i * i;
                long cube = i * i * i;

                
                Console.WriteLine($"{i} {square} {cube}");
                

                Console.WriteLine($"{i} {square + 1} {cube + 1}");
            }
        }
    }
}
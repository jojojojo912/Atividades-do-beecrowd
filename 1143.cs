using System;

class Program
{
    static void Main()
    {
       
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            
            for (int i = 1; i <= n; i++)
            {
                
                int square = i * i;
                int cube = i * i * i;

               
                Console.WriteLine($"{i} {square} {cube}");
            }
        }
    }
}
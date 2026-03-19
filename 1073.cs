using System;

class Program
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            
            if (i % 2 == 0)
            {
                
                long quadrado = (long)i * i;

                
                Console.WriteLine($"{i}^2 = {quadrado}");
            }
        }
    }
}
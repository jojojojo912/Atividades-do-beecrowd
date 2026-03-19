using System;

class Program
{
    static void Main()
    {
       
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int n))
        {
            
            for (int i = 1; i <= n; i++)
            {
                
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
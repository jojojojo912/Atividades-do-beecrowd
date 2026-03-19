using System;

class Program
{
    static void Main()
    {
        
        string input = Console.ReadLine();
        
        if (int.TryParse(input, out int n))
        {
            
            int factorial = 1;

            
            for (int i = n; i >= 1; i--)
            {
                factorial *= i;
            }

            
            Console.WriteLine(factorial);
        }
    }
}
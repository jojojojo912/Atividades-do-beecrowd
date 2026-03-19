using System;

class Program
{
    static void Main()
    {
       
        string input = Console.ReadLine();
        
        if (!string.IsNullOrEmpty(input) && int.TryParse(input.Trim(), out int n) && n > 0 && n < 46)
        {
            int a = 0;
            int b = 1;

            
            for (int i = 0; i < n; i++)
            {
               
                if (i == n - 1)
                {
                    Console.Write(a);
                }
                
                else
                {
                    Console.Write(a + " ");
                }

                
                int next = a + b;
                
                
                a = b;
                b = next;
            }
            
            
            Console.WriteLine();
        }
    }
}
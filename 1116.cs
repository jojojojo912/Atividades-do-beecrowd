using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            
            string[] entrada = Console.ReadLine().Split(' ');
            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);

            
            if (y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                
                double resultado = (double)x / y;

               
                Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
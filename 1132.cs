using System;

class Program
{
    static void Main(string[] args)
    {
       
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        
        int inicio = Math.Min(x, y);
        int fim = Math.Max(x, y);

        int soma = 0;

        
        for (int i = inicio; i <= fim; i++)
        {
            
            if (i % 13 != 0)
            {
                soma += i;
            }
        }

        
        Console.WriteLine(soma);
    }
}
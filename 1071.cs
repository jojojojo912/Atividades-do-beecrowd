using System;

class Program
{
    static void Main()
    {
        
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        
        int menor = Math.Min(x, y);
        int maior = Math.Max(x, y);

        int soma = 0;

        
        for (int i = menor + 1; i < maior; i++)
        {
            
            if (i % 2 != 0)
            {
                soma += i;
            }
        }

       
        Console.WriteLine(soma);
    }
}
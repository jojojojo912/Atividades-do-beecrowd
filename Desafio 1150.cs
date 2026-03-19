using System;

class Program
{
    static void Main()
    {
        
        int x = int.Parse(Console.ReadLine().Trim());
        int z;

        
        do
        {
            z = int.Parse(Console.ReadLine().Trim());
        } while (z <= x);

        int soma = 0;
        int contagem = 0;
        int atual = x;

        
        while (soma <= z)
        {
            soma += atual;
            atual++;
            contagem++;
        }

       
        Console.WriteLine(contagem);
    }
}
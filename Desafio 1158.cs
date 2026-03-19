using System;

class Program
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine().Trim());

        for (int i = 0; i < n; i++)
        {
            
            string[] entrada = Console.ReadLine().Trim().Split(' ');
            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);

            int soma = 0;
            int count = 0;
            int atual = x;

            
            if (atual % 2 == 0)
            {
                atual++;
            }

           
            for (int j = 0; j < y; j++)
            {
                soma += atual;
                atual += 2;
            }

            
            Console.WriteLine(soma);
        }
    }
}
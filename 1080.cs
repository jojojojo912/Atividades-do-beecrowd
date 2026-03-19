using System;

class Program
{
    static void Main()
    {
        int maiorValor = -1;
        int posicao = 0;

        
        for (int i = 1; i <= 100; i++)
        {
            
            string entrada = Console.ReadLine();
            
            
            if (!string.IsNullOrEmpty(entrada))
            {
                int valorAtual = int.Parse(entrada.Trim());

                
                if (valorAtual > maiorValor)
                {
                    
                    maiorValor = valorAtual;
                    posicao = i;
                }
            }
        }

        
        Console.WriteLine(maiorValor);
        Console.WriteLine(posicao);
    }
}
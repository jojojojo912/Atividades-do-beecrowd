using System;
using System.Globalization;

class Program
{
    static void Main()
    {
       
        int n = int.Parse(Console.ReadLine().Trim());

        
        int totalCobaias = 0;
        int totalCoelhos = 0;
        int totalRatos = 0;
        int totalSapos = 0;

       
        for (int i = 0; i < n; i++)
        {
            
            string[] entrada = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            int quantidade = int.Parse(entrada[0]);
            string tipo = entrada[1].ToUpper(); 

           
            totalCobaias += quantidade;

           
            if (tipo == "C")
            {
                totalCoelhos += quantidade;
            }
            else if (tipo == "R")
            {
                totalRatos += quantidade;
            }
            else if (tipo == "S")
            {
                totalSapos += quantidade;
            }
        }

        
        double percCoelhos = ((double)totalCoelhos / totalCobaias) * 100.0;
        double percRatos = ((double)totalRatos / totalCobaias) * 100.0;
        double percSapos = ((double)totalSapos / totalCobaias) * 100.0;

        
        Console.WriteLine($"Total: {totalCobaias} cobaias");
        Console.WriteLine($"Total de coelhos: {totalCoelhos}");
        Console.WriteLine($"Total de ratos: {totalRatos}");
        Console.WriteLine($"Total de sapos: {totalSapos}");
        
        
        Console.WriteLine($"Percentual de coelhos: {percCoelhos.ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de ratos: {percRatos.ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine($"Percentual de sapos: {percSapos.ToString("F2", CultureInfo.InvariantCulture)} %");
    }
}
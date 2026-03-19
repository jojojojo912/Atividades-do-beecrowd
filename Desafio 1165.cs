using System;

class Program
{
    static void Main()
    {
       
        int n = int.Parse(Console.ReadLine().Trim());

        for (int i = 0; i < n; i++)
        {
            
            int x = int.Parse(Console.ReadLine().Trim());

            
            if (EhPrimo(x))
            {
                Console.WriteLine($"{x} eh primo");
            }
            else
            {
                Console.WriteLine($"{x} nao eh primo");
            }
        }
    }

    
    static bool EhPrimo(int numero)
    {
        if (numero < 2) return false;
        if (numero == 2) return true;
        if (numero % 2 == 0) return false; 

        
        double limite = Math.Sqrt(numero);
        for (int i = 3; i <= limite; i += 2)
        {
            if (numero % i == 0)
            {
                return false; 
            }
        }

        return true; 
    }
}
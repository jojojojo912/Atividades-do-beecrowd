using System;

class Program
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
           
            int x = int.Parse(Console.ReadLine());

            
            if (x == 0)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                
                string paridade = (x % 2 == 0) ? "EVEN" : "ODD";

                
                string sinal = (x > 0) ? "POSITIVE" : "NEGATIVE";

                
                Console.WriteLine($"{paridade} {sinal}");
            }
        }
    }
}
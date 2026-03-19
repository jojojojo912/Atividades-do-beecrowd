using System;

class Program
{
    static void Main(string[] args)
    {
       
        int n = int.Parse(Console.ReadLine());

        
        int inicio = 1;

        for (int i = 0; i < n; i++)
        {
            
            Console.WriteLine($"{inicio} {inicio + 1} {inicio + 2} PUM");

            
            inicio += 4;
        }
    }
}
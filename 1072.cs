using System;

class Program
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());

        int countIn = 0;
        int countOut = 0;

        
        for (int i = 0; i < n; i++)
        {
            
            int x = int.Parse(Console.ReadLine());

            
            if (x >= 10 && x <= 20)
            {
                countIn++;
            }
            else
            {
                countOut++;
            }
        }

        
        Console.WriteLine($"{countIn} in");
        Console.WriteLine($"{countOut} out");
    }
}
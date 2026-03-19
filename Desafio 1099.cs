using System;

class Program
{
    static void Main()
    {
        
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            for (int i = 0; i < n; i++)
            {
                
                string[] values = Console.ReadLine().Split(' ');
                if (values.Length >= 2)
                {
                    int x = int.Parse(values[0]);
                    int y = int.Parse(values[1]);

                   
                    int start = Math.Min(x, y);
                    int end = Math.Max(x, y);
                    
                    int sum = 0;

                   
                    for (int j = start + 1; j < end; j++)
                    {
                       
                        if (j % 2 != 0)
                        {
                            sum += j;
                        }
                    }

                    
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
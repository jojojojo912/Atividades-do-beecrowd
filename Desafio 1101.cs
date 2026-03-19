using System;

class Program
{
    static void Main()
    {
        string input;
        
        
        while ((input = Console.ReadLine()) != null)
        {
            
            string[] parts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2) break;

            int m = int.Parse(parts[0]);
            int n = int.Parse(parts[1]);

            
            if (m <= 0 || n <= 0)
            {
                break;
            }

           
            int start = Math.Min(m, n);
            int end = Math.Max(m, n);
            int sum = 0;

            
            for (int i = start; i <= end; i++)
            {
               
                Console.Write(i + " ");
                sum += i;
            }

            
            Console.WriteLine("Sum=" + sum);
        }
    }
}
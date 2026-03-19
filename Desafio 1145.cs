using System;
using System.Text;

class Program
{
    static void Main()
    {
       
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) return;

        string[] parts = input.Split(' ');
        if (parts.Length < 2) return;

        int x = int.Parse(parts[0]);
        int y = int.Parse(parts[1]);

        StringBuilder output = new StringBuilder();

        for (int i = 1; i <= y; i++)
        {
            output.Append(i);

            
            if (i % x == 0)
            {
                output.AppendLine();
            }
            
            else if (i < y)
            {
                output.Append(" ");
            }
        }

        
        Console.Write(output.ToString());
        
        
        if (y % x != 0)
        {
            Console.WriteLine();
        }
    }
}
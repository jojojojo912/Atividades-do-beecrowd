using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine().Trim());

        for (int i = 0; i < n; i++)
        {
           
            string[] valores = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double media = (n1 * 2 + n2 * 3 + n3 * 5) / 10.0;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
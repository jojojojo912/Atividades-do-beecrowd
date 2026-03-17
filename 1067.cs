using System;

class Program
{
    static void Main()
    {
        // 1. Lemos a entrada do usuário como string e convertemos para inteiro
        int X = int.Parse(Console.ReadLine());

        // 2. Criamos o loop que vai de 1 até X
        for (int i = 1; i <= X; i++)
        {
            // 3. Verificamos se o resto da divisão por 2 é diferente de zero
            if (i % 2 != 0)
            {
                // 4. Imprimimos o valor de i e pulamos uma linha
                Console.WriteLine(i);
            }
        }
    }
}
// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static void Main(string[] args)
    {
        //ler o vetor 

        int n;

        Console.Write("Digite aqui o número de vetores: ");
        n = Convert.ToInt32(Console.ReadLine());

        int[] vec = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("vec ["+ i + "]: ");
            vec[i] = Convert.ToInt32(Console.ReadLine());
        }

        //identificar quais são os números negativos

        int contNeg = 0;

        for( int i = 0; i < n; i++)
        {
            if (vec[i] < 0)
            {
                contNeg++;
            }
            
        }
        Console.WriteLine("Os negativos são: " + contNeg);

        //identificar os múltiplos de 5

        int mult5 = 0;

        for ( int i = 0; i < n; i++)
        {
            if (vec[i] % 5 == 0)
            {
                mult5++;
            }
        }
        Console.WriteLine("Os números apresentados multiplos de 5 são: " + mult5);
    }
}

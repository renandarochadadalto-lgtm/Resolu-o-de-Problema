// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main()
    {
        int[] numeros = new int[6];

        Console.WriteLine("Digite 6 números:");

        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int menor = numeros[0];
        int maior = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
        }
        Console.WriteLine($"\nO menor número é: {menor}");
        Console.WriteLine($"O maior número é: {maior}");
    }
}

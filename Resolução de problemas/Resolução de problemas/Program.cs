// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main()
    {
        // Definir os 6 números
        int[] numeros = new int[6];

        // Preencher o array com os 6 números
        Console.WriteLine("Digite 6 números:");

        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Inicializar o menor e maior número com o primeiro número do array
        int menor = numeros[0];
        int maior = numeros[0];

        // Percorrer o array para encontrar o menor e maior número
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] < menor)
            {
                menor = numeros[i]; // Atualiza o menor
            }
            if (numeros[i] > maior)
            {
                maior = numeros[i]; // Atualiza o maior
            }
        }

        // Exibir o resultado
        Console.WriteLine($"\nO menor número é: {menor}");
        Console.WriteLine($"O maior número é: {maior}");
    }
}

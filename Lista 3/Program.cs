// Atividade 1
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma sequência de valores inteiros separados por espaço:");
        string[] input = Console.ReadLine().Split(' ');

        int positivos = 0;
        int negativos = 0;
        int zeros = 0;

        foreach (string item in input)
        {
            int valor = int.Parse(item);

            if (valor > 0)
            {
                positivos++;
            }
            else if (valor < 0)
            {
                negativos++;
            }
            else
            {
                zeros++;
            }
        }

        Console.WriteLine($"Número de valores positivos: {positivos}");
        Console.WriteLine($"Número de valores negativos: {negativos}");
        Console.WriteLine($"Número de zeros: {zeros}");
    }
}


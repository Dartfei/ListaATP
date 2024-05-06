// ATIVIDADE 1
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma sequência de valores inteiros separados por espaço:");
        string input = Console.ReadLine();

        string[] valores = input.Split(' ');

        int positivos = 0;
        int negativos = 0;
        int zeros = 0;

        foreach (string valor in valores)
        {
            if (int.TryParse(valor, out int numero))
            {
                if (numero > 0)
                {
                    positivos++;
                }
                else if (numero < 0)
                {
                    negativos++;
                }
                else
                {
                    zeros++;
                }
            }
            else
            {
                Console.WriteLine($"\"{valor}\" não é um número inteiro válido.");
            }
        }

        Console.WriteLine("Número de valores positivos: " + positivos);
        Console.WriteLine("Número de valores negativos: " + negativos);
        Console.WriteLine("Número de zeros: " + zeros);
    }
}



// ATIVIDADE 2

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma sequência de valores inteiros separados por espaço:");
        string input = Console.ReadLine();

        string[] valores = input.Split(' ');

        int totalValores = valores.Length;

        int positivos = 0;
        int negativos = 0;
        int zeros = 0;

        foreach (string valor in valores)
        {
            if (int.TryParse(valor, out int numero))
            {
                if (numero > 0)
                {
                    positivos++;
                }
                else if (numero < 0)
                {
                    negativos++;
                }
                else
                {
                    zeros++;
                }
            }
            else
            {
                Console.WriteLine($"\"{valor}\" não é um número inteiro válido.");
            }
        }

        double percentualPositivos = (double)positivos / totalValores * 100;
        double percentualNegativos = (double)negativos / totalValores * 100;
        double percentualZeros = (double)zeros / totalValores * 100;

        Console.WriteLine("Número de valores positivos: " + positivos + " - " + percentualPositivos.ToString("0.00") + "%");
        Console.WriteLine("Número de valores negativos: " + negativos + " - " + percentualNegativos.ToString("0.00") + "%");
        Console.WriteLine("Número de zeros: " + zeros + " - " + percentualZeros.ToString("0.00") + "%");
    }
}


// ATIVIDADE 3 

using System;

class Program
{
    static void Main(string[] args)
    {
        int divisivelPor3e9 = 0;
        int divisivelPor2e5 = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Digite o {i}º número: ");
            int numero = int.Parse(Console.ReadLine());

            if (VerificarDivisibilidadePor3e9(numero) && VerificarDivisibilidadePor2e5(numero))
            {
                divisivelPor3e9++;
                divisivelPor2e5++;
            }
            else if (VerificarDivisibilidadePor3e9(numero))
            {
                divisivelPor3e9++;
            }
            else if (VerificarDivisibilidadePor2e5(numero))
            {
                divisivelPor2e5++;
            }
            else
            {
                Console.WriteLine($"O número {numero} não é divisível pelos valores.");
            }
        }

        Console.WriteLine($"Quantidade de números divisíveis por 3 e 9: {divisivelPor3e9}");
        Console.WriteLine($"Quantidade de números divisíveis por 2 e 5: {divisivelPor2e5}");
    }

    static bool VerificarDivisibilidadePor3e9(int numero)
    {
        int somaDigitos = 0;
        while (numero != 0)
        {
            somaDigitos += numero % 10;
            numero /= 10;
        }
        return somaDigitos % 3 == 0;
    }

    static bool VerificarDivisibilidadePor2e5(int numero)
    {
        return numero % 2 == 0 && (numero % 10 == 0 || numero % 10 == 5);
    }
}


// ATIVIDADE 4 

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número natural para calcular o fatorial:");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("Número inválido. O número deve ser não negativo.");
        }
        else
        {
            long fatorial = CalcularFatorial(numero);
            Console.WriteLine($"{numero}! = {fatorial}");
        }
    }

    static long CalcularFatorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        long resultado = 1;
        for (int i = 1; i <= n; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
}

//ATIVIDADE 5

    using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor inteiro e positivo para N:");
        int N = int.Parse(Console.ReadLine());

        if (N < 0)
        {
            Console.WriteLine("Número inválido. O número deve ser positivo.");
        }
        else
        {
            double E = CalcularE(N);
            Console.WriteLine($"O valor de E é: {E}");
        }
    }

    static double CalcularE(int N)
    {
        double E = 1; // O primeiro termo é sempre 1

        for (int i = 1; i <= N; i++)
        {
            E += 1.0 / CalcularFatorial(i);
        }

        return E;
    }

    static long CalcularFatorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        long resultado = 1;
        for (int i = 1; i <= n; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
}

// ATIVIDADE 6  

using System;

class Program
{
    static void Main(string[] args)
    {
        double somaSalarios = 0;
        int somaFilhos = 0;
        double maiorSalario = 0;
        int countSalarioAte100 = 0;
        int numHabitantes = 0;

        Console.WriteLine("Digite o salário do habitante (ou um número negativo para encerrar a leitura):");
        double salario = double.Parse(Console.ReadLine());

        while (salario >= 0)
        {
            Console.WriteLine($"Digite o número de filhos do habitante:");
            int filhos = int.Parse(Console.ReadLine());

            somaSalarios += salario;
            somaFilhos += filhos;
            numHabitantes++;

            if (salario > maiorSalario)
            {
                maiorSalario = salario;
            }

            if (salario <= 100)
            {
                countSalarioAte100++;
            }

            Console.WriteLine("Digite o salário do próximo habitante (ou um número negativo para encerrar a leitura):");
            salario = double.Parse(Console.ReadLine());
        }

        if (numHabitantes > 0)
        {
            double mediaSalarios = somaSalarios / numHabitantes;
            double mediaFilhos = (double)somaFilhos / numHabitantes;
            double percentualSalarioAte100 = (double)countSalarioAte100 / numHabitantes * 100;

            Console.WriteLine($"Média do salário da população: R${mediaSalarios:F2}");
            Console.WriteLine($"Média do número de filhos: {mediaFilhos:F2}");
            Console.WriteLine($"Maior salário: R${maiorSalario:F2}");
            Console.WriteLine($"Percentual de pessoas com salário até R$100,00: {percentualSalarioAte100:F2}%");
        }
        else
        {
            Console.WriteLine("Nenhum dado foi inserido.");
        }
    }
}



//ATIVIDADE 7

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor inteiro e positivo para N:");
        int N = int.Parse(Console.ReadLine());

        if (N <= 0)
        {
            Console.WriteLine("Número inválido. O número deve ser positivo.");
        }
        else
        {
            double S = 0;

            for (int i = 1; i <= N; i++)
            {
                double termo = 1.0 / i;
                S += termo;
                Console.WriteLine($"Termo {i}: {termo:F6}");
            }

            Console.WriteLine($"Valor final de S: {S:F6}");
        }
    }
}

// ATIVIDADE 8

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o número de elementos da sequência de Fibonacci que deseja imprimir:");
        int L = int.Parse(Console.ReadLine());

        if (L <= 0)
        {
            Console.WriteLine("Número inválido. O número deve ser positivo.");
        }
        else
        {
            Console.WriteLine("Os primeiros " + L + " elementos da sequência de Fibonacci são:");

            int anterior = 0;
            int atual = 1;

            Console.Write(anterior + " " + atual + " ");

            for (int i = 2; i < L; i++)
            {
                int proximo = anterior + atual;
                Console.Write(proximo + " ");
                anterior = atual;
                atual = proximo;
            }
        }
    }
}


// ATIVIDADE 9

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor para L:");
        int L = int.Parse(Console.ReadLine());

        if (L <= 0)
        {
            Console.WriteLine("Número inválido. O número deve ser positivo.");
        }
        else
        {
            int soma = 0;
            int anterior = 0;
            int atual = 1;

            while (atual < L)
            {
                soma += atual;

                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }

            Console.WriteLine("A soma de todos os elementos da série de Fibonacci menores que " + L + " é: " + soma);
        }
    }
}

// ATIVIDADE 10

using System;

class Program
{
    static void Main(string[] args)
    {
        double totalCompra = 0;
        double totalVenda = 0;
        double lucroTotal = 0;
        int lucroMenor10 = 0;
        int lucroEntre10e20 = 0;
        int lucroMaior20 = 0;

        Console.WriteLine("Digite o preço de compra da mercadoria (ou 0 para encerrar):");
        double precoCompra = double.Parse(Console.ReadLine());

        while (precoCompra != 0)
        {
            Console.WriteLine("Digite o preço de venda da mercadoria:");
            double precoVenda = double.Parse(Console.ReadLine());

            totalCompra += precoCompra;
            totalVenda += precoVenda;

            double lucro = precoVenda - precoCompra;
            lucroTotal += lucro;

            if (lucro < precoCompra * 0.10)
            {
                lucroMenor10++;
            }
            else if (lucro <= precoCompra * 0.20)
            {
                lucroEntre10e20++;
            }
            else
            {
                lucroMaior20++;
            }

            Console.WriteLine("Digite o preço de compra da próxima mercadoria (ou 0 para encerrar):");
            precoCompra = double.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Quantidade de mercadorias com lucro < 10%: {lucroMenor10}");
        Console.WriteLine($"Quantidade de mercadorias com lucro entre 10% e 20%: {lucroEntre10e20}");
        Console.WriteLine($"Quantidade de mercadorias com lucro > 20%: {lucroMaior20}");
        Console.WriteLine($"Valor total de compra: {totalCompra}");
        Console.WriteLine($"Valor total de venda: {totalVenda}");
        Console.WriteLine($"Lucro total: {lucroTotal}");
    }
}


// ATIVIDADE 11

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] votos = new int[7]; // Array para contar os votos para cada candidato (índices 1 a 4), votos nulos (índice 5) e votos em branco (índice 6).

        Console.WriteLine("Digite o código do candidato (ou 0 para encerrar a votação):");

        int voto = int.Parse(Console.ReadLine());

        while (voto != 0)
        {
            switch (voto)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    votos[voto]++;
                    break;
                case 5:
                    votos[5]++;
                    break;
                case 6:
                    votos[6]++;
                    break;
                default:
                    Console.WriteLine("Código de voto inválido.");
                    break;
            }

            Console.WriteLine("Digite o código do próximo voto (ou 0 para encerrar a votação):");
            voto = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Total de votos para o candidato 1: {votos[1]}");
        Console.WriteLine($"Total de votos para o candidato 2: {votos[2]}");
        Console.WriteLine($"Total de votos para o candidato 3: {votos[3]}");
        Console.WriteLine($"Total de votos para o candidato 4: {votos[4]}");
        Console.WriteLine($"Total de votos nulos: {votos[5]}");
        Console.WriteLine($"Total de votos em branco: {votos[6]}");
    }
}


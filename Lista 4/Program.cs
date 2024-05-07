using System;

class Program
{
    static void Main(string[] args){

        Console.WriteLine ( "Informe a nota do aluno ");
        int numAlunos = int.Parse( Console.ReadLine());
        
        for( int i = 1; i <= numAlunos; i++);

            Console.WriteLine ($"Aluno {i}:");
            Console.WriteLine ("Informe a Primeira nota:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine ("Informe a segunda nota:");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine ("Informe a terceira nota:")
            double nota3 = double.Parse(Console.ReadLine());

            Console.ReadLine ("Digite 'A' para média aritmética ou 'P' para média ponderada");

            char opcao = char.Parse(Console.ReadLine());

            if ( opcao == 'A')
            {
                double mediarite = CalcularMediaAritmetica( nota1, nota2, nota3);
                Console.WriteLine ($"A media aritmética: {mediarite}");
            }





    }
}

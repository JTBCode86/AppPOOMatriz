using System;

namespace AppPOOMatriz
{
    /// <summary>
    /// Exercicio Matriz
    /// Neste exercicio, será criada a classe Matriz, deixando as operações de matriz
    /// sob responsabilidade dela.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com os valores de uma matriz bidimencional com espaço: ");
            string[] values = Console.ReadLine().Split(" ");

            int n = int.Parse(values[0]);
            int m = int.Parse(values[1]);
            matriz objMatriz = new matriz(n, m);
            Console.WriteLine();

            Console.WriteLine("Entre com os valores da matriz abaixo: ");
            objMatriz.preencheMatriz();
            Console.Clear();

            Console.WriteLine("Os valores atuais são: ");
            objMatriz.imprimirMatriz();
            Console.ReadLine();
            Console.Clear();

            Console.Write("Entre com o valor da multiplicados: ");
            int x = int.Parse(Console.ReadLine());
            objMatriz.multiplicarMatriz(x);
            Console.Clear();

            Console.WriteLine("Os valores atuais na matriz são: ");
            objMatriz.imprimirMatriz();

            Console.ReadLine();
        }
    }
}

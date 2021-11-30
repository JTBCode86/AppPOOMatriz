using System;

namespace AppPOOMatriz
{
    class matriz
    {
        public int n { get; set; }
        public int m { get; set; }

        public int[,] mat;

        public matriz(int M, int N) 
        {
            this.m = M;
            this.n = N;
        }

        public void preencheMatriz() 
        {
             mat = new int[m,n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
        }

        public void imprimirMatriz() 
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int[,] multiplicarMatriz(int x) 
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = mat[i, j] * x;
                }
            }
            return mat;
        }
    }
}

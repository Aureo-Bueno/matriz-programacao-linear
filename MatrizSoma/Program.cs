class Program
{
    static void Main(string[] args)
    {
        int[,] matrizA = { { 6, -10, 8 }, { -2, 8, 12  } };
        int[,] matrizB = { { -5,-25 }, { 15, 10 } };

        Console.WriteLine("Matriz A:");
        ImprimirMatriz(matrizA);

        Console.WriteLine("Matriz B:");
        ImprimirMatriz(matrizB);

        int[,] matrizSoma = SomaMatrizes(matrizA, matrizB);

        Console.WriteLine("Matriz soma:");
        ImprimirMatriz(matrizSoma);
    }

    static int[,] SomaMatrizes(int[,] matrizA, int[,] matrizB)
    {
        int linhas = matrizA.GetLength(0);
        int colunas = matrizA.GetLength(1);

        int[,] matrizSoma = new int[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matrizSoma[i, j] = matrizA[i, j] + matrizB[i, j];
            }
        }

        return matrizSoma;
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

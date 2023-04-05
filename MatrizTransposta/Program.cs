class Program
{
    static void Main(string[] args)
    {
        int[,] matrizOriginal = { { -2, -10 }, { 6,-4 } };

        Console.WriteLine("Matriz original:");
        ImprimirMatriz(matrizOriginal);

        int[,] matrizTransposta = TransporMatriz(matrizOriginal);

        Console.WriteLine("Matriz transposta:");
        ImprimirMatriz(matrizTransposta);
    }

    static int[,] TransporMatriz(int[,] matrizOriginal)
    {
        int linhas = matrizOriginal.GetLength(0);
        int colunas = matrizOriginal.GetLength(1);

        int[,] matrizTransposta = new int[colunas, linhas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matrizTransposta[j, i] = matrizOriginal[i, j];
            }
        }

        return matrizTransposta;
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

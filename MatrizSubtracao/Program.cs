class Program
{
    static void Main(string[] args)
    {
        int[,] A = { { 3,-5,4 }, { -1,4,6 } }; // matriz A
        int[,] B = { { -1,4,2 }, { -5,-2,3} }; // matriz B
        int[,] C = new int[2, 2]; // matriz resultado

        // subtrai as matrizes A e B e armazena o resultado na matriz C
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                C[i, j] = A[i, j] - B[i, j];
            }
        }

        // exibe a matriz resultado C
        Console.WriteLine("Matriz resultado C:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(C[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

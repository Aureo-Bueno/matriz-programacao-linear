int[,] A = new int[3, 3] { { 2,0,-1 }, {3,5,2 }, {-4,1,4 } };
int[,] B = new int[3, 3] { {5,1,-2 }, { -1,0,4 }, { 2,-3,3 } };
int[,] C = new int[3, 3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        int sum = 0;
        for (int k = 0; k < 3; k++)
        {
            sum += A[i, k] * B[k, j];
        }
        C[i, j] = sum;
    }
}

// Exibir matriz C
Console.WriteLine("Matriz C:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(C[i, j] + " ");
    }
    Console.WriteLine();
}
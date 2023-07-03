using System;

public class Program
{
    public static int ContarSubmatriz(int[,] matrizA, int[,] matrizB)
    {
        int count = 0;
        int rowsA = matrizA.GetLength(0);
        int colsA = matrizA.GetLength(1);
        int rowsB = matrizB.GetLength(0);
        int colsB = matrizB.GetLength(1);

        for (int i = 0; i <= rowsA - rowsB; i++)
        {
            for (int j = 0; j <= colsA - colsB; j++)
            {
                bool encontrada = true;
                for (int k = 0; k < rowsB; k++)
                {
                    for (int l = 0; l < colsB; l++)
                    {
                        if (matrizA[i + k, j + l] != matrizB[k, l])
                        {
                            encontrada = false;
                            break;
                        }
                    }
                    if (!encontrada)
                        break;
                }
                if (encontrada)
                    count++;
            }
        }

        return count;
    }

    public static void Main()
    {
        int[,] matrizA = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };

        int[,] matrizB = {
            {6, 7},
            {10, 11}
        };

        int quantidade = ContarSubmatriz(matrizA, matrizB);
        Console.WriteLine("Quantidade de vezes que a submatriz B ocorre em A: " + quantidade);
    }
}



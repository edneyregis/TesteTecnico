using System;

public class Program
{
    public static void InverterDiagonais(int[,] matriz)
    {
        int tamanho = matriz.GetLength(0);
        for (int i = 0; i < tamanho / 2; i++)
        {
            int temp = matriz[i, i];
            matriz[i, i] = matriz[tamanho - 1 - i, tamanho - 1 - i];
            matriz[tamanho - 1 - i, tamanho - 1 - i] = temp;

            temp = matriz[i, tamanho - 1 - i];
            matriz[i, tamanho - 1 - i] = matriz[tamanho - 1 - i, i];
            matriz[tamanho - 1 - i, i] = temp;
        }
    }

    public static void Main()
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        InverterDiagonais(matriz);

        int tamanho = matriz.GetLength(0);
        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
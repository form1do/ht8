// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
 int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minRnd, maxRnd + 1);
        }
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void SortingRowsArrayMaxMin(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int n = 0; n < matrix.GetLength(1) - 1; n++)
            {
                if (matrix[i, n] < matrix[i, n + 1])
                {
                    int temporary = matrix[i, n + 1];
                    matrix[i, n + 1] = matrix[i, n];
                    matrix[i, n] = temporary;
                }
            }
        }
    }
    PrintArray(matrix);
}

int[,] myMatrix = GenerateArray(rows: 4, columns: 7, minRnd: 0, maxRnd: 20);
PrintArray(myMatrix);
SortingRowsArrayMaxMin(myMatrix);

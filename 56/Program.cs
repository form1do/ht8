//Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов
int[,] CreateMatrix(int rows, int columns, int minRnd, int maxRnd)
{
    int[,] matrix= new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minRnd, maxRnd + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] Usermatrix)
{
    for (int i = 0; i < Usermatrix.GetLength(0); i++)
    {
        for (int j = 0; j < Usermatrix.GetLength(1); j++)
        {
            System.Console.Write($"{Usermatrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int MinSumElementsRow(int[,] array)
{
    int minRow = 0;
    int sumElementRow = 0;
    int minSumRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSumRow += array[0, j];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int n = 0; n < array.GetLength(1); n++) sumElementRow += array[i, n];
        if (sumElementRow < minSumRow)
        {
            minSumRow = sumElementRow;
            minRow = i;
        }
        sumElementRow = 0;
    }
    return minRow;
}

int[,] myMatrix = CreateMatrix(rows:2, columns: 2, minRnd: 0, maxRnd: 17);
PrintMatrix(myMatrix);
System.Console.WriteLine($"Cтрока {MinSumElementsRow(myMatrix)+1} с наименьшей суммой элементов");
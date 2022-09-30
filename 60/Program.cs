// Напишите программу, которая заполнит спирально массив 4 на 4
int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int [,] CreateArray (int size){
    int[,] matrix = new int[size, size];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = 0;
        }
    }
    return matrix;
}

int[,] GetSpiralMatrix(int [,] matrix)
{
    int[,] spiralMatrix = matrix;
    int size = matrix.GetLength(0);
    for (int i = 0; i < spiralMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < spiralMatrix.GetLength(1); j++)
        {
            int num = 1;
            for (int step = 0; step < size - 2; step++)
            {
                for (int n = 0 + step; n < size - step; n++)
                {
                    spiralMatrix[0 + step, n] = num;
                    num++;
                }
                num--;
                for (int n = 0 + step; n < size - step; n++)
                {
                    spiralMatrix[n, size - 1 - step] = num;
                    num++;
                }
                num--;
                for (int n = size - 1 - step; n >= 0 + step; n--)
                {
                    spiralMatrix[size - 1 - step, n] = num;
                    num++;
                }
                num--;
                for (int n = size - 1 - step; n >= 1 + step; n--)
                {
                    spiralMatrix[n, 0 + step] = num;
                    num++;
                }
            }
        }
    }
    return spiralMatrix;
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

int size = Prompt("Введите размер массива: ");
int [,] matrix = CreateArray(size);
int [,] spiralMatrix = GetSpiralMatrix(matrix);
PrintArray (spiralMatrix);

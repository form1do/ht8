// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] FillArray(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

int[,] MultypliMatrix(int[,] firstMaxrix, int[,] secondMaxrix)
{
    int[,] resultMatrix = new int[firstMaxrix.GetLength(0), firstMaxrix.GetLength(1)];
    for (int i = 0; i < firstMaxrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMaxrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < firstMaxrix.GetLength(1); k++)
            {
                resultMatrix[i, j] += firstMaxrix[i, k] * secondMaxrix[k, j];
            }
        }
    }
    return resultMatrix;
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

int size = Prompt("Введите размер двух матриц: ");
int[,] firstMaxrix = FillArray(size, size);
System.Console.WriteLine("Первая матрица > ");
PrintArray(firstMaxrix);
int[,] secondMaxrix = FillArray(size, size);
System.Console.WriteLine("Вторая матрица > ");
PrintArray(secondMaxrix);
int[,] result = MultypliMatrix(firstMaxrix, secondMaxrix);
System.Console.WriteLine("Результатирующая матрица > ");
PrintArray(result);

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая 
// будет построчно выводить массив, добавляя индексы каждого элемента.
 int[,] GenerateArray(int a, int b, int c, int minRnd, int maxRnd)
{
    int[,] array = new int[a, b , c];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for( int k=0; k < array.GetLength(2); k++)
            array[i, j, k] = new Random().Next(minRnd, maxRnd + 1);
        }
    }
    return array;
}
Int[] FindAndChangeEqual(int [,,] matrix){
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for( int k=0; k < array.GetLength(2); k++){
                if (matrix[i,j,k] == matrix [i+1,j+1,k+1]){
                    matrix[i,j,k] = new Random().Next(9, 100);
                }
           FindAndChangeEqual(matrix); 
                return matrix;

            }

void PrintMatrix(int[,] Usermatrix)
{
    for (int i = 0; i < Usermatrix.GetLength(0); i++)
    {
        for (int j = 0; j < Usermatrix.GetLength(1); j++)
        {
            for (int j = 0; j < Usermatrix.GetLength(1); j++){
 System.Console.Write($"{Usermatrix[i, j, k]} ({i},{j},{k}\t");
           
        System.Console.WriteLine();}
    }
}
}
    
int userArray = GenerateArray (2,2,2,9,100);
int resultMatrix = FindAndChangeEqual(userArray);
PrintMatrix (resultMatrix);

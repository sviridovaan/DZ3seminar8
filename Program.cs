//Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц
Console.Clear();
void ShowArray(int [,] array)
{
    for (int i = 0; i<array.GetLength(0) ; i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int [,] array = new int [rows, columns]; 
    for (int i = 0; i<rows ; i++)
    {
        for (int j = 0; j<columns; j++)
        {
            array [i,j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return array;
}

int [,] matrix1 = CreateRandomArray(2, 2, 1, 4);
int [,] matrix2 = CreateRandomArray(2, 2, 1, 4);
Console.WriteLine("Матрица 1: ");
ShowArray(matrix1);
Console.WriteLine("Матрица 2: ");
ShowArray(matrix2);

int [,] matrixResult = new int [2, 2];
void MultMatrix(int [,] matrix1, int [,] matrix2, int [,] matrixResult)
{
  for (int i = 0; i < matrixResult.GetLength(0); i++)
  {
    for (int j = 0; j < matrixResult.GetLength(1); j++)
    {
      int result = 0;
      for (int index = 0; index < matrixResult.GetLength(1); index++)
      {
        result += matrix1[i,index] * matrix2[index,j];
      }
      matrixResult[i,j] = result;
    }
  }
}
MultMatrix(matrix1, matrix2, matrixResult);
Console.WriteLine("Результирующая матрица равна:");
ShowArray(matrixResult);


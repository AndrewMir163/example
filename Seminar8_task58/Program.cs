/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */


Console.WriteLine("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов первой матрицы: ");
int cols1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов второй матрицы: ");
int cols2 = Convert.ToInt32(Console.ReadLine());


int[,] firstMartrix = new int[rows, cols1];
FillArray(firstMartrix);

Console.WriteLine("Первая матрица:");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[rows, cols2];
FillArray(secomdMartrix);

Console.WriteLine("Вторая матрица:");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[rows,cols2];

MultiplicationMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine("Произведение первой и второй матриц: ");
PrintArray(resultMatrix);

void MultiplicationMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 9);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
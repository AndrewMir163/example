﻿/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.WriteLine("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[rows, cols];

Console.WriteLine();
FillArray(array);
PrintArray(array);


int minLine = 0;
int sumLine = LineSumlements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempLine = LineSumlements(array, i);
  if (sumLine > tempLine)
  {
    sumLine = tempLine;
    minLine = i;
  }
}

Console.WriteLine();
Console.WriteLine($"{minLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


int LineSumlements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}


void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,11);
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
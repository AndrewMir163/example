/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */




Console.WriteLine("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int cols = Convert.ToInt32(Console.ReadLine());

int [,] numbers = new int [7,9];


FillArrayRandomNumbers(numbers);
PrintArray(numbers);

Console.WriteLine(); // для отступа

if (rows-1 >= numbers.GetLength(0) || cols - 1 >= numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($" Элементом строки {rows} и столбца {cols} является: {numbers[rows,cols]}");
}




void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100);
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("( ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write(")");
        Console.WriteLine(); 
        Console.WriteLine(); 
    }
}
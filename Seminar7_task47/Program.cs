/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
 */



Console.WriteLine("Укажите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[rows, cols];


void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100));
        }
    }
}



void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("( ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write(")");
        Console.WriteLine();
        Console.WriteLine();

    }
}


FillArrayRandomNumbers(numbers);
PrintArray(numbers);

/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */


Console.WriteLine("Введите значение числа N: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;

Console.WriteLine();

Console.WriteLine($" Натуральные числа в промежутке от {n} до {m}: {NaturalNumber(n, m)}");

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}


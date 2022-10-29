/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

int i = 1;

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Четные числа: ");

while (i <= num)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
    }
    else
    {
        Console.Write("--");
    }
    i++;
}
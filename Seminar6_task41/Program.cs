/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

/* Console.Write("Введите любые числа (через пробел): ");

int[] array = Array.ConvertAll(Console.ReadLine().Split(),Convert.ToInt32);
int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Чисел > 0: {count}");
 */

Console.Write("Введите любые числа : ");

string[] number = Convert.ToString( Console.ReadLine());

int size = number.Length;

void ArrayPrint(string[]number)
{
    for (int i = 0; i< size; i++)
    {
        Console.Write("," (number[i]));
    }
}

Console.WriteLine(ArrayPrint);




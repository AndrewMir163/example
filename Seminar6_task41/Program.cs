/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

Console.Write("!!!Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine()!);

Console.WriteLine();

PrintArray(numbers);


int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}

Console.WriteLine(" ");

Console.WriteLine($"Количество числе > 0 = {sum}");


int[] StringToNum(string array)

{
    int count = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        string temp = "";

        while (array [i] != ',')
        {
        if(i != array.Length - 1)
        {
            temp += array [i].ToString();
            i++;
        }
        else
        {
            temp += array [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}


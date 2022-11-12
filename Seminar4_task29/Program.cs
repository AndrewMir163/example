/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
 */

 
int [] numbers = new int[8];
int size = numbers.Length;
for (int i = 0; i < size; i++)
 {
    numbers [i] = new Random().Next(-999, 999);
    Console.Write(" " + Method (i) + " ");
 }

int Method (int i)
{
    return numbers[i];
}
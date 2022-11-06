//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

Console.WriteLine("Введите число");

int a = int.Parse(Console.ReadLine()!);

string strA = a.ToString();

int size = strA.Length;

if ( size > 2)
{
    Console.WriteLine("3-я цифра числа:  " + strA[2]);
}
else
{
    Console.WriteLine("недостаточно цифр в числе");
}





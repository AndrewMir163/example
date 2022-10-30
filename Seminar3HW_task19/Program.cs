/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

Console.WriteLine("Введите 5ти занчное число:");
int number = int.Parse(Console.ReadLine()!);

int inversNum (int number)
{
    int a = number % 10;
    int b = number / 10 % 10;
    int c = number / 100 % 10;
    int d = number / 1000 % 10;
    int e = number / 10000 % 10;
    int inversNum = a*10000 + b*1000 + c*100 + d*10 + e;
    return inversNum;
}

int newNumber = inversNum(number);

if (newNumber == number)
{
    Console.WriteLine("Полиндром , все гуд");
}
else
{
    Console.WriteLine("Не полиндром(");
} 
 
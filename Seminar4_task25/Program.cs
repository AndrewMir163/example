﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите число A: ");
int numberA = Convert.ToInt32( Console.ReadLine()!);
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine()!);


int exponentiation = Exp(numberA, numberB);
Console.WriteLine("Ответ: " + exponentiation);


int Exp(int numberA, int numberB)
{
  int result = Convert.ToInt32(Math.Pow(numberA, numberB));
  return result;
}
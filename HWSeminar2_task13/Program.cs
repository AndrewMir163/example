//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6



Console.WriteLine("Введите число");

int a = int.Parse (Console.ReadLine()!);
string str = a.ToString();
int[] b = new int[str.Length];
for( int i=0; i< str.Length; i++)
{
     b[i] = int.Parse(str);
     Console.WriteLine(b);
}
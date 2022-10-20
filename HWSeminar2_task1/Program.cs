//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1


int Seconddigit(int digit)
{
    int Seconddigit = digit / 10 % 10;
    return Seconddigit;
}


Console.WriteLine("Введите 3-х значное число");
int digit = int.Parse (Console.ReadLine());

int Secondnumber = Seconddigit(digit);

Console.Write("Вторая цифра числа:");
Console.WriteLine (Secondnumber);



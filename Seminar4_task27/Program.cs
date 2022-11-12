// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32( Console.ReadLine()!);

int NumberSUM = NumbersSum(number);
Console.WriteLine($"Сумма чисел числа {number} = {NumberSUM}");


int NumbersSum(int number)
{
    
    int arraySize = Convert.ToString(number).Length;
    int invers = 0;
    int sum = 0;

    for (int i = 0; i < arraySize; i++)
    {
      invers = number - number % 10;
      sum = sum + (number - invers);
      number = number / 10;
    }
   return sum;
  }


/* 
Почему не работает код ниже???????? */


/*  int NumbersSum(int number)
{ 
string strNum = number.ToString();
int size = strNum.Length;
int sum = 0;

 for (int i =0 ; i < size; i++ )
{
    sum = sum+strNum[i];
  
} 
return sum;

} 
 */

 
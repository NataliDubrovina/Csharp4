/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int Length(int a)
{
    int index = 0;
    while (a > 0)
    {
       a /= 10;
       index++;
    }
    return index;
}

int Sum(int a, int length)
{
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
       sum += a % 10;
       a /= 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int length = Length(a);
int sum = Sum(a, length);
Console.Write(sum);
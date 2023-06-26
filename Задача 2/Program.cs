/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

// int ReadInt(string text)  
// {     System.Console.Write(text);     
//       return Convert.ToInt32(Console.ReadLine()); 
// }

// int Numbers(int number) 
// {     
//     int i = number.length;
//     while (i!=0)
//     {
//         number3 = number3 * number1;
//         number2 -= 1;
//     }
//     return number3;
// }

// int number1 = ReadInt("Введите первое число: "); 



// Подсчет количества символов в числе
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
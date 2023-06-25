/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит
число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int ReadInt(string text)  
{     System.Console.Write(text);     
      return Convert.ToInt32(Console.ReadLine()); 
}

int Numbers(int number1, int number2) 
{     
    int number3 = 1;
    while (number2!=0)
    {
        number3 = number3 * number1;
        number2 -= 1;
    }
    return number3;
}

int number1 = ReadInt("Введите первое число: "); 
int number2 = ReadInt("Введите второе число, оно должно быть натуральным: ");

if (number2<1)
Console.Write("Bторое число должно быть натуральным");
else
{
    int number3 = Numbers(number1, number2);
    Console.Write($"Первое число в натуральной степени второго равно {number3}");
}
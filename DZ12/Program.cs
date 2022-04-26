// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

using System;
Console.Clear();
Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine());


/*int Res(int num)
{
   if (num < 10)
       return num;
   int del = num % 10;
   int nextdel = num / 10;
   return del + Res(nextdel);
}
Console.WriteLine(Res(A));*/

int Res(int num)
{   
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num/10;
    }
    return sum;
}
Console.WriteLine(Res(A));
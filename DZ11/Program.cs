//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


using System;
Console.Clear();
Console.WriteLine("Введите первое число");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = int.Parse(Console.ReadLine());

  Console.WriteLine($"{A}^{B} = {(int)Math.Pow(A, B)}");

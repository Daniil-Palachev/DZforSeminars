/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


Console.Clear();
Console.WriteLine("Введите начальное число");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конечное число");
int n = int.Parse(Console.ReadLine()!);

int result = Summ(m, n);
Console.WriteLine(result);
Console.WriteLine();

int Summ(int start, int end)
{
    if (start == end) return start;
    if (end < start)
        return start + Summ(--start, end);
    else
        return start + Summ(++start, end);
}
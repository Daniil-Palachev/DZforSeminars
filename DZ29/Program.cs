/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29*/


Console.Clear();
Console.WriteLine("Введите начальное число");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конечное число");
int n = int.Parse(Console.ReadLine()!);

int result = Akerman(m, n);
Console.WriteLine(result);
Console.WriteLine();

int Akerman(int a, int b)
{
    if (a == 0) return b + 1;
        else
        if (a > 0 && b == 0) return Akerman(a - 1, 1);
            else return Akerman(a - 1, Akerman(a, b - 1));
}

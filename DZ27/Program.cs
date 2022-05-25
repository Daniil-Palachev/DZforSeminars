/*Задайте значения M и N. Напишите программу, которая выведет все натуральные числа по убыванию в промежутке от M до N.

M = 1; N = 5. -> "5, 4, 3, 2, 1"

M = 4; N = 8. -> "8, 7, 6, 5, 4"*/

Console.Clear();
Console.WriteLine("Введите начальное число");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конечное число");
int n = int.Parse(Console.ReadLine()!);

string result = GetNumbers(m, n);
Console.WriteLine(result);
Console.WriteLine();

string GetNumbers(int start, int end)
{
    int temp;
    if (start > end)
        {
            if (start == end) return start.ToString();
            return (start + " " + GetNumbers(start - 1, end));
        }
                else
                {
                    temp = start;
                    start = end;
                    end = temp;
                    if (start == end) return start.ToString();
                    return (start + " " + GetNumbers(start - 1, end));
                }
}
 



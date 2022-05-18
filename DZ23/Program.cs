/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/


Console.Clear();

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine($"m = {m}, n = {n}");
int [,] array = new int [m,n];
Print (Getarray(array));
Console.WriteLine();
SummLines(array);


void SummLines(int [,] array)
{
    
    int min = 0;
    int k = 0;
    for (int x = 0; x<array.GetLength(0); x++)
    {   
            int sum = 0;
            for (int y = 0; y < array.GetLength(1) - y - 1; y++) 
            {
                sum += array[x,y];
            }
        if (x == 0)
        {
            min = sum;
            k = x;
        }
            else if (sum<min)
            {
                min = sum;
                k = x;
            }
    } 

    Console.WriteLine(k);
}


int [,] Getarray(int [,] array)
{
    Random r = new Random();
    for (int x = 0; x<array.GetLength(0);x++)
    {
        for (int y = 0; y<array.GetLength(1);y++)
        array [x,y] = r.Next(0, 9);  
    }
    return array;
}
 

 void Print (int [,] array)
{
    for (int x = 0; x<array.GetLength(0); x++)
    {
        for (int y = 0; y<array.GetLength(1); y++)
        Console.Write(array[x,y]); 
        Console.WriteLine();  
    }
    
}


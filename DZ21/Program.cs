/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.Clear();

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine($"m = {m}, n = {n}");
int [,] array = new int [m,n];
Print (Getarray(array));
FindAverage(array);

void FindAverage(int [,] array)
{
    int sum = 0;
    for (int x = 0; x<array.GetLength(0); x++)
    {
        for (int y = 0; y<array.GetLength(1); y++) 
        {
            sum += array[y,x]; 
        }
        Console.WriteLine(sum/array.GetLength(1));
        
    }
   
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
/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8*/

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
Print (FromMintoMax(array));


int [,] FromMintoMax(int [,] array)
{
    for (int x = 0; x<array.GetLength(0); x++)
    {
        for (int y=0; y<array.GetLength(1); y++)
        {
            for (int k = 0; k < array.GetLength(1) - y - 1; k++) 
                if (array[x,k+1]<array[x,k])
                {
                    int min = array[x,k];
                    array[x,k] = array[x,k+1];
                    array[x,k+1] = min;
                }  
        } 

    }
    return array;
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

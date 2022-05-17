/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/

Console.Clear();

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine($"m = {m}, n = {n}");

Console.Write("Введите число для проверки: ");
int f = Convert.ToInt32(Console.ReadLine());
int [,] array= new int [m,n];
Print (Getarray(array));

bool isNumberInArray= false;
for (int x = 0; x<array.GetLength(0);x++)
{
    for (int y=0; y<array.GetLength(1);y++)
    if (array[x,y]==f)
    {
       isNumberInArray=true;
    }
}
Console.WriteLine(isNumberInArray?"такое число есть в массиве":"такого числа нет в массиве");
 
int [,] Getarray(int [,] array)
{
    Random r=new Random();
    for (int x=0; x<array.GetLength(0);x++)
    {
        for (int y=0; y<array.GetLength(1);y++)
        array [x,y]=r.Next(0, 9);  
    }
    return array;
}
 
 void Print (int [,] array)
{
    for (int x=0; x<array.GetLength(0);x++)
    {
        for (int y=0; y<array.GetLength(1);y++)
        Console.Write(array[x,y]); 
        Console.WriteLine();  
    }
    
}
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine($"m = {m}, n = {n}");

double [,] array= new double [m,n];

Print (Getarray(array));

double [,] Getarray(double [,] array)
{
    Random r=new Random();
    for (int x=0; x<array.GetLength(0);x++)
    {
        for (int y=0; y<array.GetLength(1);y++)
        array [x,y]=Convert.ToDouble(r.Next(-50, 50))/10;  
    }
    return array;
}
 
 void Print (double [,] array)
{
    for (int x=0; x<array.GetLength(0);x++)
    {
        for (int y=0; y<array.GetLength(1);y++)
        Console.Write(array[x,y]); 
        Console.WriteLine();  
    }
    
}
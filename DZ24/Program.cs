/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

и

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10

20 81 8 6

56 8 4 24

10 6 24 49*/

Console.Clear();

int rows = 5;
int columns = 6;
int min = 1;
int max = 11;

int[,] array = GetArray(rows, columns, min, max);
int[,] array2 = GetArray(rows, columns, min, max);
int[,] array3 = multiplication(array, array2, rows, columns);
Print(array);
Console.WriteLine();
Print(array2);
Console.WriteLine();
Print(array3);

int[,] multiplication(int[,] array, int[,] array2, int rows, int columns)
{
    int[,] array3 = new int[rows, columns];
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            array3[x, y] = array[x, y] * array2[x, y];
        }
    }
    return array3;
}



int[,] GetArray(int rows, int columns, int min = 0, int max = 100)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}


void Print(int[,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
            Console.Write($"{array[x, y]}  ");
        Console.WriteLine();
    }

}

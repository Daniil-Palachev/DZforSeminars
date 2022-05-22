/*Задача 62.Заполните спирально массив.
Например, на выходе получается вот такой массив:

1 2 3 4

12 13 14 5

11 16 15 6

10 9 8 7*/
Console.Clear();

int rows = 5;
int columns = 6;


int [,] array = Ulitka(rows);
Print(array);
Console.WriteLine();

int[,] Ulitka(int rows)
{
    int[,] array = new int[rows, rows];
    int k = 1;
    int temp = 0;
    int i, j = 0;
    int m = rows;
    while (k <= m * m)
    {
        for (i = temp; i < rows; i++) 
            array[j, i] = k++;
        j = i - 1;
        for (i = temp + 1; i < rows; i++)
            array[i, j] = k++;
        for (i = rows - 2; i >= temp; i--)
            array[j, i] = k++;
        j = temp;
        for (i = rows - 2; i > temp; i--)
            array[i, j] = k++;
        rows--;
        temp++;
        j = temp;
    }
    return array;
}

void Print(int[,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
            Console.Write("{0,3}", array[x, y]);
        Console.WriteLine();
    }

}
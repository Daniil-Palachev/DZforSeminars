/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)*/

Console.Clear();

int rows = 2;
int columns = 2;
int polochki = 2;
int min = 1;
int max = 11;

int[,,] array = GetArrayPolochki(rows, columns, polochki, min, max);

Print(GetArrayPolochki(rows, columns, polochki));
Console.WriteLine();


int[,,] GetArrayPolochki(int rows, int columns, int polochki, int min = 0, int max = 100)
{
    int[,,] result = new int[rows, columns, polochki];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < polochki; k++)
            {
                result[i, j, k] = i * 100 + j * 10 + k;
            }
        }
    }
    return result;
}


void Print(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[x, y, k]}  "); 
            }
               Console.WriteLine();
        }
    }

}

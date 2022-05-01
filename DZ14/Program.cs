/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/


Console.Clear();
Console.WriteLine($"Количество чётных чисел в массиве:");


int[] Array = new int[10].Select(x => new Random().Next(100, 899)).ToArray();
Console.WriteLine(String.Join(", ", Array));

int QuantityPositive(int[] array)
{
    int quantity = 0;
    for (int i = 0; i<Array.Length; i++ )
  {
    if (Array[i] % 2 == 0)
    {
      quantity++;
    }
  }
  return quantity;
}

Console.WriteLine($"Количество чётных чисел в массиве: {QuantityPositive(Array)}");
/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/


Console.Clear();
Console.WriteLine($"Сумма эллементов на нечетных позициях:");


int[] Array = new int[10].Select(x => new Random().Next(-100, 200)).ToArray();
Console.WriteLine(String.Join(", ", Array));

int sum(int[] array)
{
    int quantity = 0;
    for (int i = 0; i<Array.Length; i=i+2)
  {
    
      quantity= quantity+array[i];
    
  }
  return quantity;
}

Console.WriteLine($"Сумма эллементов на нечетных позициях: {sum(Array)}");
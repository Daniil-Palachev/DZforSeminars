/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/


Console.Clear();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива:");


int[] Array = new int[10].Select(x => new Random().Next(0, 100)).ToArray();
Console.WriteLine(String.Join(", ", Array));

    int min = Array[0];
    int max = Array[0];
    int result = 0;
    for (int i = 0; i<Array.Length; i++)
  {
    if (Array[i]> max)
    {
      max= Array[i];  
    } 
    else if (Array[i]< min)
    {
      min= Array[i];
    }
  result= max-min;
}

Console.WriteLine(result);
Console.Clear();
Console.WriteLine("введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

string num=(num1%2==0)?$"четное": $"не четное";
Console.WriteLine(num);
Console.WriteLine("Введите число");
int sqrt = int.Parse(Console.ReadLine());
int count= 0;

while (count<=sqrt)
{
    double i = Math.Pow(count, 3);
    count++;
    Console.Write($"{i} ");
}
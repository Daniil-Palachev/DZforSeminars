Console.WriteLine("введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

int max=(num1>num2&&num1>num3)?num1:(num2>num1&&num2>num3)?num2:num3;
Console.WriteLine($"максимальное число {max}");


int num1 = new Random().Next(0,20);
Console.WriteLine(num1);

for (int count=2; count<=num1; count+=2)
Console.WriteLine(count);
/*while (count<num1)
{   
    if (count%2==0)
    {   
        Console.WriteLine(count);
        count++;
    }
    else
    count++;
}*/

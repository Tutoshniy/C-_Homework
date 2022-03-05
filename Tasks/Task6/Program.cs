Console.Clear();
int a = new Random().Next(10,99);
Console.Write("Дано число: ");
Console.WriteLine(a);
int max = 0;
while (a > 0)
{
    if (a %10 >= max) max = a % 10;
    a = a / 10;
}
Console.Write("Максимальная цифра числа: ");
Console.WriteLine(max);
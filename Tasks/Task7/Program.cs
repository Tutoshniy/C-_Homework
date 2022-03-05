Console.Clear();
Console.WriteLine("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;
int ost = 0;
while (a >= 100)
{
    ost = ost + ((a % 10) * count);
    count *= 10;
    a /= 10;
}
a = a/10 * count + ost;
Console.Write("Получишееся число: ");
Console.WriteLine(a);
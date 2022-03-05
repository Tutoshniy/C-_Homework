Console.WriteLine("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a >= 100)
{
    a = a / 10;
}
a = a % 10;
Console.Write("Вторая цифра трёхзначного числа - ");
Console.WriteLine(a);
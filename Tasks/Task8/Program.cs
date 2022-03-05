Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a >= b)
{
    if (a % b == 0)
    {
        Console.Write("Кратность найдена и она равна: ");
        Console.WriteLine(a / b);
    }
    else
    {
        Console.Write("Кратность отсутствует. Остаток от деления равен: ");
        Console.WriteLine(a % b);
    }
}
if (a < b)
{
    if (b % a == 0)
    {
        Console.Write("Кратность найдена и она равна: ");
        Console.WriteLine(b / a);
    }
    else
    {
        Console.Write("Кратность отсутствует. Остаток от деления равен: ");
        Console.WriteLine(b % a);
    }
}
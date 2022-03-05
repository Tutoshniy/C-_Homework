Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 100)
{
    while (a >= 1000)
    {
        a /= 10;
    }
    a %= 10;
    Console.Write("Третья цифра числа - ");
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("У числа отсутсвует третья цифра");
}
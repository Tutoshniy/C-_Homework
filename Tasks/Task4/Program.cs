Console.Clear();
Console.WriteLine("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Последняя цифра числа: ");
Console.WriteLine(a%10);
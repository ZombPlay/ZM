double y;
double d = 0;
Console.Write("Введите первое число: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
double c = double.Parse(Console.ReadLine());
if (a != 0 && b != 0 && c != 0)
{
    d = 1 / a + 1 / b + 1 / c;
    if (d > 0 && a > 0)
    {
        y = Math.Sqrt(d);
    }
    else
    {
        y = 2;
    }
    Console.WriteLine($"y={y}");

}
else
{
    Console.WriteLine("Нет решения!");
}




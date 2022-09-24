Console.Write("Введите первое число: ");
int a= int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b= int.Parse(Console.ReadLine());

Console.Write("Введите 3 число: ");
int c= int.Parse(Console.ReadLine());

double y = 0;
double x = 0;

if (a > b && b > c)
{
  x=0.2;
    y = (x * x) + 0.6 * x + Math.Sin(x / 2);
}
else if (b<c && a<c)
{
    x = 2;
    y = Math.Pow(x, 3) + (x * x) + x + 1;
}
else
{
    x = 0;
    y = 0;
}
Console.WriteLine($"X = {x}");
Console.WriteLine($"Y = {y}");
Console.WriteLine("Введите два числа которые будут меньше 10");

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

double y = 0;

switch ((a * b) / (a + b))
{
    case 0:
        y = 1 / (a + b);
        break;

    case 1:
    case 2:
        y = (a + b) / (b * b);
        break;

    case 3:
        y = (a * a) + (b * b);
        break;

    case 4:
        y = b * Math.Cos(a);
        break;

    case 5:
        y = a * Math.Sin(b);
        break;

    default:
        y = 0;
        break;

}

Console.WriteLine($"Y равен = {y}");
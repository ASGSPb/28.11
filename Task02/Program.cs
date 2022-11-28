//  Напишите программу,
//  которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
System.Console.Write("Даны две прямые заданные уравнениями: ");
System.Console.WriteLine("y = k1 * x + b1 и y = k2 * x + b2");
System.Console.WriteLine();

System.Console.WriteLine("Введите данные: ");

System.Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine();

System.Console.WriteLine($"y = {k1} * x + {b1}; y = {k2} * x + {b2};");
System.Console.WriteLine();

double x = 0;
double y = 0;

if (k1 - k2 != 0 && b2 - b1 != 0)
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    System.Console.WriteLine($"Прямые пересекаются в точке с координатами х {x}; y{y};");
    System.Console.WriteLine();
}
else if (b2 - b1 == 0)
{
    System.Console.WriteLine($"Прямые совпадают");
    System.Console.WriteLine();
}
else if (k1 - k2 == 0)
{
    System.Console.WriteLine($"Прямые параллельны");
    System.Console.WriteLine();
}

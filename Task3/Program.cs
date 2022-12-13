// Задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. 
// Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.

void Check(double a, double b, double c)
{
    if (a < b + c && b < a + c && c < a + b)
        Console.WriteLine($"Треугольник со сторонами равными {a}, {b} и {c} существует");
    else Console.WriteLine($"Треугольник со сторонами равными {a}, {b} и {c} не может существовать");
}

void Info(double a, double b, double c)
{
    double p = a + b + c;
    double p1 = (a + b + c) / 2;
    double s = Math.Sqrt(p1 * (p1 - a) * (p1 - b) * (p1 - c));
    double res_s = Math.Round(s, 2);
    Console.WriteLine($"Периметр треугольника равен = {p}");
    Console.WriteLine($"Площадь треугольника равна = {res_s}");
}

double Corner(double a, double b, double c)
{
    double cos_a = (Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c);
    double corner_a = Math.Acos(cos_a) * 57.2956;
    double res_a = Math.Round(corner_a, 2);
    return res_a;
}

void Info2(double a, double b, double c)
{
    if (a == b && b == c && a == c)
        Console.WriteLine("Треугольник равносторонний");
    else if (a == b || b == c || a == c)
        Console.WriteLine("Треугольник равнобедренный");
    else if (Corner(a, b, c) == 90 || Corner(b, a, c) == 90 || Corner(c, b, a) == 90)
        Console.WriteLine("Треугольник - прямоугольный");
    else Console.WriteLine("Треугольник - разносторонний");
}

try
{
    Console.WriteLine("Введите длину стороны A");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите длину стороны B");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите длину стороны C");
    double c = Convert.ToDouble(Console.ReadLine());
    Check(a, b, c);
    Info(a, b, c);
    Info2(a, b, c);
}

catch
{
    Console.WriteLine("Надо ввести целое число!!!");
}

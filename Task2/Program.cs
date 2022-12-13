// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void Count(double b1, double b2, double k1, double k2)
{
    if (b1 == -b2 && k1 == k2)
        Console.WriteLine($"Точка пересечения первой прямой y = {k1}*x + {b1} и второй прямой y = {k2}*x + {b2} отсутствует, прямые параллельны");
    else if (b1 == b2 && k1 == k2 && b1 == k1) Console.WriteLine($"Прямые y = {k1}*x + {b1} и y = {k2}*x + {b2} одинаковы, это одна и та же прямая");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;
        Console.WriteLine($"Точка пересечения первой прямой y = {k1}*x + {b1} и второй прямой y = {k2}*x + {b2}, равна точке A = ({x}; {y})");
    }
}

try
{
    Console.WriteLine("Введите значение переменной k1");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение переменной b1");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение переменной k2");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение переменной b2");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Count(b1, b2, k1, k2);
}

catch
{
    Console.WriteLine("Надо ввести число!!!");
}
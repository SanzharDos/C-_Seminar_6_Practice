// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PrintArray(int[] size)
{
    Console.Write("{ ");
    foreach (int el in size)
    {
        Console.Write($"{el} ");
    }
    Console.Write("}");
    Console.WriteLine();
}

void CreateArray(int size)
{
    int[] array = new int[size];
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1}-е число");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0) count++;
    }
    PrintArray(array);
    Console.WriteLine($"Количество положительных чисел в массиве составляет - {count}");
}

try
{
    Console.WriteLine("Введите размерность массива");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    CreateArray(n);
}

catch
{
    Console.WriteLine("Надо ввести целое число!!!");
}

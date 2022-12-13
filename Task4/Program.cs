// Задача 1 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, найти максимальное число и его индекс. Вывести эту информацию на экран.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("{ ");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
            Console.Write($"{matr[i, j]} ");
        }
        Console.Write("}");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Check(int[,] matr)
{
    int min_i = 0;
    int min_j = 0;
    int max_i = 0;
    int max_j = 0;
    int min = matr[0, 0];
    int max = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                min_i = i;
                min_j = j;
            }
        }
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] > max)
            {
                max = matr[i, j];
                max_i = i;
                max_j = j;
            }
        }
    }
    Console.WriteLine($"Максимальное значение массива равно = {max} и его индекс = [{max_i}, {max_j}], минимальное значение массива равно = {min} и его индекс = [{min_i}, {min_j}]");
}

try
{
    Console.WriteLine("Введите размерность массива по строкам");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите размерность массива по столбцам");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];
    Console.WriteLine($"Сгенерирован массив из случаыйных чисел размером строк - {m} и столбцов - {n}:");
    PrintArray(array);
    Check(array);
}

catch
{
    Console.WriteLine("Надо ввести целое число!!!");
}
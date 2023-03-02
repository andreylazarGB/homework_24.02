//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
int length = Prompt("Введите длинну масива: ");
int minValue = Prompt("Введите минимальное значение элемента массива: ");
int maxValue = Prompt("Введите максимальное значение элемента массива: ");
double[] array = FillArray(length, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Разница чисел между min и max значением элемена массива равна: {DifferenceMinMaxInArray(array)}");


int Prompt(string massage)
{
    Console.WriteLine(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[] FillArray(int Length, int min, int max)
{
    double[] array = new double[Length];
    Random rnd = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = rnd.Next(min, max + 1) + rnd.NextDouble();
        array[i] = Math.Round(array[i], 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write($"]");
}

double DifferenceMinMaxInArray(double[] array)
{
    double min = array[0];
    double max = array[1];
    double result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        else if (array[i] > max) max = array[i];
        result = max - min;
    }
    return result;
}


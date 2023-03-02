//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int length = Prompt("Введите длинну масива: ");
int min = Prompt("Введите минимальное значение элемента массива: ");
int max = Prompt("Введите максимальное значение элемента массива: ");
int[] array = FillArray(length, min, max);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях равна {SumEvenElements(array)}");


int Prompt(string massage)
{
    Console.WriteLine(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] FillArray(int Length, int min, int max)
{
    int[] array = new int[Length];
    Random rnd = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}

int SumEvenElements(int[] array)
{
    int result = 0;
    for (int i = 0; i < length; i++)
        if (i % 2 == 1)
        {
            result += array[i];
        }
    return result;
}

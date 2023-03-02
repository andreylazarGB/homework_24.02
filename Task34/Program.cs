/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2  */

Console.Clear();

int Length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение, для диапозона случайного числа: ");
//int min1 = GetNumber(min);
int max = Prompt("Конечное значение, для диапозона случайного числа: ");
//int max2 = GetNumber(max);
int[] array = FillArray(Length, min, max);
Console.WriteLine($"В массиве [{string.Join(", ", array)}] количество четных чисел равно {GetCountEvenNumbers(array)}");


int Prompt(string massage)
{
    Console.WriteLine(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

// ВОПРОС КАК ПРЕКРАТИТЬ ВЫПОЛНЕНИЕ И ВЕРНУТЬСЯ К ВВОДУ ЧИСЛА???
/*int GetNumber(int x1)
{
    if (x1 < 99 || x1 > 999)
    {
        Console.WriteLine("Число не трехзначное!!!");
    }
    return x1;
}*/

int[] FillArray(int size, int minX, int max)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(min, max + 1);
    }
    return result;
}

int GetCountEvenNumbers(int[] Array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}






/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int[] InitArray()
{
    int[] result = new int[4];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(100);
    }

    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

(int, int) GetMinMax(int [] arr)
{
    int min = arr.Min();
    int max = arr.Max();


    return (min, max);
}

int [] arr = InitArray();
PrintArray(arr);
(int min, int max) = GetMinMax(arr);
int result = max-min;

Console.WriteLine($"Максимальный элемент = {max}, Минимальный элемент = {min}, Разница между максимальным и минимальным элементами массива = {result}");
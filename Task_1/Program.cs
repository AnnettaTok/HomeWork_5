/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2


*/

int[] InitArray()
{
    int[] result = new int[4];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(100, 999);
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

int GetSum(int[] arr)
{
    int sum = 0;
    foreach (int element in arr)
    {
    
    if (element % 2 == 0)
        sum++;
    }
    return sum;

}

int[] arr = InitArray();
PrintArray(arr);
var result = GetSum(arr);
Console.WriteLine(result);

/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int[] InitArray()
{
    int[] result = new int[4];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-100,100);
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
    
    for (int i = 1; i < arr.Length; i+=2)
   
        
        sum = sum + arr[i];
    

    return sum;

}

int[] arr = InitArray();
PrintArray(arr);
var result = GetSum(arr);
Console.WriteLine(result);

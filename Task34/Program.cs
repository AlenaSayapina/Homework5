// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int count = 0;


int[] getArray(int arr)
{
    int[] array = new int[arr];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (array[i] % 2 == 0)
        count++;
    }
    return array;
}

Console.Write("[ ");
foreach (int n in getArray(size))
{
    Console.Write(n + " ");
}
Console.Write("]");

Console.WriteLine();
Console.WriteLine($"Kоличество чётных чисел в массиве: {count}");



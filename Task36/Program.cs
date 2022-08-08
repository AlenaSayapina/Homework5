//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int init = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int[] getArray(int arr)
{
    int[] array = new int[arr];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);

        if (i % 2 != 1)
        {
            sum = sum + array[i];
        }
    }
    return array;
}

Console.Write("[ ");
foreach (int n in getArray(init))
{
    Console.Write(n + " ");
}
Console.Write("]");

Console.WriteLine();
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {sum}");

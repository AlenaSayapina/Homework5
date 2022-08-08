//Задача 38: Задайте массив вещественных чисел. 
//найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
int arrayNumb = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[arrayNumb];
GetArrayNumb(numbers);
Check(numbers);

int min = Int32.MaxValue;
int max = Int32.MinValue;

for (int m = 0; m < numbers.Length; m++)
{
    if (numbers[m] > max)
        {
            max = numbers[m];
        }
    if (numbers[m] < min)
        {
            min = numbers[m];
        }
}

void GetArrayNumb(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(new Random().Next(0,100));
        }
}
void Check(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
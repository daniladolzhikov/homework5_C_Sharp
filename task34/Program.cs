// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(99, 1000);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

int CountEventNumbers(int[] array)
{
    int EvenCount = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0)
        {
            EvenCount++;
        }
    }
    return EvenCount;
}

int[] array = new int[4];
FillArray(array);
System.Console.WriteLine("Сгенерированный массив");
PrintArray(array);
int EvenCount = CountEventNumbers(array);
System.Console.WriteLine("Количество четных чисел: " + EvenCount);

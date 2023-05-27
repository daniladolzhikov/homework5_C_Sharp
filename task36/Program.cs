// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 10);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

int SumOfOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum +=array[i];
    }
    return sum;
}

int[] array = new int[5];
FillArray(array);
System.Console.WriteLine("Сгенерированный массив");
PrintArray(array);
int sum = SumOfOddPositions(array);
System.Console.WriteLine("Сумма нечетных чисел: " + sum);
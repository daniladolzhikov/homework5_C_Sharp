// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next( 1, 10);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

int DiffMinMax(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
    }
    
    int difference = max - min;
    return difference;
}


int[] array = new int[5];
FillArray(array);
System.Console.WriteLine("Сгенерированный массив");
PrintArray(array);
int difference = DiffMinMax (array);
System.Console.WriteLine("Разница между max и min элементами равна: " + difference);
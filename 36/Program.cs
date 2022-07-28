// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] fillArray(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        arr[index] = new Random().Next(1, 50);
        index++;
    }
    return arr;
}

int SumArr(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    int result = 0;
    while (index < length)
    {
        if (index % 2 != 0) result = result + arr[index];
        index++;
    }
    return result;
}


int[] array = new int[10];
fillArray(array);

Console.WriteLine(String.Join(", ", array));
Console.WriteLine(SumArr(array));
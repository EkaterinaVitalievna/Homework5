// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int [] fillArray(int n) // Метод заполнения массива
{
    int[] arr = new int [n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 999);
    }
    return arr;
}

int findEven(int[] arr1) // Метод поиска кол-ва чётных элементов в массиве
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] % 2 == 0)
        count = count+1;
    }
    return count;
}  

int[] array = fillArray(10);

Console.WriteLine(string.Join(", ", array)); // Вывод массива для проверки правильности решения.

int even = findEven(array);

Console.WriteLine("Количество чётных элементов в массиве: " + even);
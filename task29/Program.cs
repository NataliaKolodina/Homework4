// Задача 29. Напишите программу, которая задает массив и 8 элементов и выводит его на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int[] arr = new int[8];
RandomArray(arr);
PrintArray(arr);

void RandomArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write(array[i] + ", ");
    }
}

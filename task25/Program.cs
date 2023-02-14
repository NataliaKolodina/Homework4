// Задача 25. Напишите цикл, который принимает на вход 2 числа (А и В) и возводит число А в натуралтную степень В.
// 3, 5 -> 243 (3 в 5)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"{a}, {b} -> {RaiseToPow(a, b)}");

int RaiseToPow(int num1, int num2)
{
    int result = 1;
    while (num2 > 0)
    {
        result = result * num1;
        num2--;
    }
    return result;
}

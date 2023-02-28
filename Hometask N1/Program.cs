// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();
System.Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
PrintNumbers(N);

void PrintNumbers(int num)
{
    if (num == 0) return;
    if (num < 0)            // Для ненатуральных чисел
    {
        System.Console.Write($"{num} ");
        PrintNumbers(num + 1);
    }
    if (num > 0)            // Для натуральных чисел
    {
        System.Console.Write($"{num} ");
        PrintNumbers(num - 1);
    }
}
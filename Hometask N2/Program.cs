// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
System.Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
if (M > N)                                  // если первое число больше второго, то программа это учтет
{
    int temp = M;
    M = N;
    N = temp;
}
int result = GetSumNumbers(M, N);
System.Console.WriteLine($"Сумма натуральных чисел равна {result}");

int GetSumNumbers(int num1, int num2)
{
    int sum = num2;
    if (num2 < num1 || num2 <= 0) return 0;
    return sum += GetSumNumbers(num1, num2 - 1);
}
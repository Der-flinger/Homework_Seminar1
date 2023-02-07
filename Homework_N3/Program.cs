// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

Console.Write("Вводимое число: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
int M = N;

if (N == 0) 
{
    System.Console.WriteLine("Введите число отличное от нуля");
    return;
}

if (N < 0) 
{
    i = N;
    N = -1;
}

System.Console.Write($"Кубы чисел до {M} -->   ");
while (i <= N)
{
    System.Console.Write($"{i * i} ");
    i++;
}
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

System.Console.Write("Enter the array length: ");
int length = int.Parse(Console.ReadLine()!);                    // задаем переменную в которой длина массива, введенная с клавиатуры
int[] A = new int[length];                                      // создаем массив

void newArray(int[] array, int minValue, int maxValue)          // функция для заполнения массива
{
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}
int EvenSumm(int[] array)                                       // функция для выведения кол-ва четных чисел
{
    int i = 0;
    int count = 0;
    while(i < length)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
        i++;
    }
    return count;
}

newArray(A, 100, 999);
Console.WriteLine($"Кол-во четных чисел равно {EvenSumm(A)}"); 
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

System.Console.Write("Enter the array length: ");
int length = int.Parse(Console.ReadLine()!);                    // задаем переменную в которой длина массива, введенная с клавиатуры
int[] A = new int[length];                                      // создаем массив

void newArray(int[] array)                                      // функция для заполнения массива
{
    System.Console.Write("Enter min Value of array: "); 
    int minValue = int.Parse(System.Console.ReadLine()!);       // переменная в которой минимальное значение элемента массива
    System.Console.Write("Enter max Value of array: ");
    int maxValue = int.Parse(System.Console.ReadLine()!);       // переменная в которой максимально значение элемента массива

    for (int i = 0; i < length; i++)                            // цикл, заполняющий наш массив
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();                                 // writeline, чтобы перенестись на новую строку 
                                                                // после выведения элементов массива на экране
}

int GetSummOddIndex(int[] array)                                // функция для подсчета и вывода суммы нужных элементов
{
    int summ = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        summ += array[i];
    }
    return summ;
}

newArray(A);
Console.WriteLine($"Сумма чисел, стоящих на нечетных индексах = {GetSummOddIndex(A)}");
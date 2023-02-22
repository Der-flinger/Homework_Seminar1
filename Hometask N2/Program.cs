// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
System.Console.Write("Введите кол-во строк: ");
int raw = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите кол-во столбцов: ");
int column = int.Parse(Console.ReadLine()!);
int[,] mainArray = Get2DArray(raw, column, 0, 99);
System.Console.WriteLine();

System.Console.WriteLine("Исходный двумерный массив");
PrintArray(mainArray);
System.Console.WriteLine();
GetRawSumFromArray2D(mainArray);

int[,] Get2DArray(int rawLength, int columnLength, int minValue, int maxValue)  // метод для получения массива
{
    int[,] array2D = new int[rawLength, columnLength];
    for (int i = 0; i < rawLength; i++)
    {
        for (int j = 0; j < columnLength; j++)
        {
            array2D[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array2D;
}

void PrintArray(int[,] array2D)     // метод для выведения массива на экран
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write($"{array2D[i, j]} ");
        }
        System.Console.WriteLine();
    }
    
}

void GetRawSumFromArray2D(int[,] array2D)        // метод, показывающий сумму всех строк и  
{                                                   // определяющий строку с наименьшей суммой
    int rawSum = 0;                         // переменная для записи суммы каждой строки
    int minSum = 2147483647;                
    int[] rawSumArray = new int[array2D.GetLength(0)];  // массив, где хранятся все суммы строк двумерного массива
    int index = 0;                          // индекс для выбора минимальной суммы из rawSumArray
    int count = 0;                          // счетчик для подсчета одинаковых минимальных элементов из rawSumArray
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)     // цикл для суммирования строк двумерного массива
        {
            rawSum += array2D[i, j]; 
        }

        System.Console.WriteLine($"Сумма {i + 1} строки равна {rawSum}");   // вывод на консоль суммы строк по порядку
        if (rawSum < minSum) 
        {
            index = i + 1;
            minSum = rawSum;
        }
        rawSumArray[i] = rawSum;
        rawSum = 0;
    }

    for (int i = 0; i < rawSumArray.Length; i++)
    {
        if (rawSumArray[i] == minSum) count++;              // если в массиве rawSumArray встречается больше двух одинаковых минимальных
    }                                                       // элементов, то наименьшую сумму элементов имеют несколько строк
    System.Console.WriteLine();

    if (count > 1) System.Console.WriteLine($"Строка {index} и еще несколько строк имеют одинаковую наименьшую сумму элементов, равную {minSum}");
    else System.Console.WriteLine($"Строка {index} имеет наименьшую сумму элементов, равную {minSum}");
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
System.Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);                             // количество строк
System.Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);                             // количество столбцов
System.Console.Write("Введите минимальный элемент массива: ");
int minElement = int.Parse(Console.ReadLine()!);                    // минимальный элемент массива
System.Console.Write("Введите максимальный элемент массива: ");
int maxElement = int.Parse(Console.ReadLine()!);                    // максимальный элемент массива
float[,] baseArray = Get2DArray(m, n, minElement, maxElement);      // двумерный массив соответствующий запросам
GetElmntValue(baseArray);

float[,] Get2DArray (int raw, int column, int minValue, int maxValue) // метод для заполнения и выведения жвумерного массива
{
    float[,] array2D = new float[raw, column];
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array2D[i, j] = new Random().Next(minValue, maxValue + 1);
            System.Console.Write($"{array2D[i, j]} ");
        }
        System.Console.WriteLine();
    }
    return array2D;
}

void GetElmntValue(float[,] array2D)                                  // метод, который показывает элемент либо сообщение, что такого элемента нет
{
    System.Console.WriteLine("Введите позицию строки и столбца массива через пробел: ");
    string index = Console.ReadLine()!;                                 // позиция строки и столбца в одной строке
    string[] strArray = index.Split(" ");
    if (Convert.ToInt32(strArray[0]) > m || Convert.ToInt32(strArray[1]) > n) 
    {
        Console.WriteLine("Такого элемента нет, позиция за пределами массива!");
        System.Console.WriteLine();
        return;
    }
    System.Console.WriteLine($"Элемент под позицией [{strArray[0]}, {strArray[1]}] равен {array2D[Convert.ToInt32(strArray[0]) - 1, Convert.ToInt32(strArray[1]) - 1]}");
}
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

int[,] mainArray = Get2DArray(3, 7, 0, 99);                         // создаем и заполняем случайный массив с указанными в скобках параметрами
System.Console.WriteLine("Случайный двумерный массив");             // вывводим массив на экран для удобства
Prin2DArray(mainArray);                                             // с помощью данного метода
System.Console.WriteLine();
PrintAvarageInColumn(mainArray);

int[,] Get2DArray (int raw, int column, int minValue, int maxValue) // метод для заполнения и выведения жвумерного массива
{
    int[,] array2D = new int[raw, column];
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array2D[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array2D;
}

void Prin2DArray (int[,] array2D)                                   // метод для вывода на экран двумерного массива
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void PrintAvarageInColumn(int[,] array2D)                           // метод отображающий среднее арифметическое в столбцах
{
    float summ = 0;
    System.Console.WriteLine("Среднее арифметическое каждого столбца ниже");
    for (int i = 0; i < array2D.GetLength(1); i++)
    {
        for (int j = 0; j < array2D.GetLength(0); j++)
        {
            summ += array2D[j, i];
        }
        System.Console.Write($"{summ / array2D.GetLength(0):f1}  "); // выводим в одну строку среднее арифметическое каждого столбца
        summ = 0;                                                    // обнуляем сумму на следующем столбце
    }
}
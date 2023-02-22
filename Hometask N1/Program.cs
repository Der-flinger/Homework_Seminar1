// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
System.Console.Write("Введите кол-во строк: ");
int raw = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите кол-во столбцов: ");
int column = int.Parse(Console.ReadLine()!);
int[,] mainArray = Get2DArray(raw, column, -9, 9);
System.Console.WriteLine();

System.Console.WriteLine("Исходный двумерный массив");
PrintArray(mainArray);

int[] rawArray = GetSortRawsFromArray2D(mainArray);
System.Console.WriteLine();

System.Console.WriteLine("Результирующий отсортированный по строкам массив");
CreateAndPrintSortArray2D(rawArray);

int[,] Get2DArray(int rawLength, int columnLength, int minValue, int maxValue)  // метод для получения массива
{
    int[,] array2D = new int[rawLength, columnLength];
    for (int i = 0; i < rawLength; i++)
    {
        for (int j = 0; j < columnLength; j++)
        {
            array2D[i, j] = new Random().Next(minValue, maxValue);
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

int[] GetSortRawsFromArray2D(int[,] array2D)        // метод для сортировки строк и добавления 
{                                                   // их в одномерный массив
    int[] line = new int[array2D.GetLength(1)];     // массив для сохранения отдельной строки
    int[] raws = new int[array2D.GetLength(0) * array2D.GetLength(1)];   // массив для сохранения всех строк 
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)      // цикл в котором сортируются строки по отдельности
        {
            line[j] = array2D[i, j];                        // строку записываем в отдельный массив
            if (j == line.Length - 1)                       // если наша строка станет равна количеству столбцов,
            {                                               // то мы эту строку отсортируем
                int temp;
                for (int k = 0; k < line.Length; k++)       // сортировка пузырьковым методом отдельной строки
                {
                    for (int l = 0; l < line.Length - 1 - k; l++)
                    {
                        if (line[l] < line[l + 1]) 
                        {
                            temp = line[l];
                            line[l] = line[l + 1];
                            line[l + 1] = temp;
                        }
                    }
                }
            }
            
        }
        for (int x = 0; x < array2D.GetLength(1); x++)      // цикл, где записываем все отсортированные строки 
        {                                                   // двумерного массива в одномерный массив в ряд
            raws[(i * array2D.GetLength(1)) + x] = line[x];
        }
    }
    return raws;
}

void CreateAndPrintSortArray2D (int[] array)         // метод, где полученный одномерный массив пихаем обратно в двумерный 
{                                                       // и выводим результат на экран
    int[,] resultArray = new int[mainArray.GetLongLength(0), mainArray.GetLongLength(1)];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i, j] = array[j + i * resultArray.GetLength(1)];    // заполняем двумерный массив элементами одномерного массива
            System.Console.Write($"{resultArray[i, j]} ");                  // выводим на экран результирующий двумерный массив
        }
        System.Console.WriteLine();
    }
}
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:

Console.Clear();
System.Console.Write("Введите кол-во строк первой матрицы: ");
int raw1 = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите кол-во столбцов первой матрицы: ");
int column1 = int.Parse(Console.ReadLine()!);
int[,] matrix1 = Get2DArray(raw1, column1, 1, 9);

System.Console.Write("Введите кол-во строк второй матрицы: ");
int raw2 = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите кол-во столбцов второй матрицы: ");
int column2 = int.Parse(Console.ReadLine()!);
int[,] matrix2 = Get2DArray(raw2, column2, 1, 9);
System.Console.WriteLine();

System.Console.WriteLine("Первая матрица");
PrintArray(matrix1);
System.Console.WriteLine();

System.Console.WriteLine("Вторая матрица");
PrintArray(matrix2);
System.Console.WriteLine();

int[,] multipliedArray = PrintMultiplicationArrays(matrix1, matrix2);
PrintArray(multipliedArray);
System.Console.WriteLine();

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

int[,] PrintMultiplicationArrays(int[,] array1, int[,] array2)          // метод, который умножает две матрицы и возвращает результат
{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];     // результирующая матрица
    if(array1.GetLength(1) != array2.GetLength(0))
    {
        System.Console.WriteLine("Для умножения матриц количество столбцов первой матрицы должно совпадать с количеством строк второй матрицы");
        System.Environment.Exit(0);                     // в случае срабатывания условия завершаем процесс с выводом сообщения
    }
    for (int i = 0; i < resultArray.GetLength(0); i++)          // заполнение результирующего массива в циклах ниже
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                resultArray[i,j] += array1[i, k] * array2[k, j];
            }
        }
    }
    System.Console.WriteLine("После умножения двух матриц получаем матрицу ниже");
    return resultArray;
}
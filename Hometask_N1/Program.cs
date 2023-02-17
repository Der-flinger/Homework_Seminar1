// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();
float[,] baseArray = Get2DArray(4, 5, 1, 99);
Prin2DArray(baseArray);

float[,] Get2DArray (int raw, int column, int minValue, int maxValue) // метод для заполнения и выведения жвумерного массива
{
    float[,] array2D = new float[raw, column];
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array2D[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array2D;
}
void Prin2DArray (float[,] array2D)                                   // метод для вывода на экран двумерного массива
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
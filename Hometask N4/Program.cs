// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();

System.Console.Write("Введите кол-во слоев трехмерного массива: ");
int layer = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите кол-во строк трехмерного массива: ");
int raw = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите кол-во столбцов трехмерного массива: ");
int column = int.Parse(Console.ReadLine()!);
System.Console.WriteLine();

int[,,] mainArray = Get3DArray(layer, raw, column, 10, 99);

System.Console.WriteLine("Трехмерный массив ниже");
Print3DArray(mainArray);

int[,,] Get3DArray(int layerLength, int rawLength, int columnLength, int minValue, int maxValue)  // метод для получения массива
{
    int[,,] array3D = new int[layerLength, rawLength, columnLength];
    for (int k = 0; k < layerLength; k++)
    {
        for (int i = 0; i < rawLength; i++)
        {
            for (int j = 0; j < columnLength; j++)
            {
                int element = new Random().Next(minValue, maxValue + 1);
                if (checkForNonRepeatingElements(array3D, element)) 
                {
                    array3D[k,i,j] = new Random().Next(10, 99);
                    if (checkForNonRepeatingElements(array3D, element)) continue;
                    continue;
                }
                array3D[k, i, j] = element;
            }
        }
    }
    return array3D;
}

bool checkForNonRepeatingElements(int[,,] array3D, int element)
{
    for (int k = 0; k < array3D.GetLength(0); k++)
    {
        for (int i = 0; i < array3D.GetLength(1); i++)
        {
            for (int j = 0; j < array3D.GetLength(2); j++)
            {
                if (array3D[k, i, j] == element) return true; 
            }
        }
    }
    return false;
}

void Print3DArray(int[,,] array3D)     // метод для выведения массива на экран
{
    for (int k = 0; k < array3D.GetLength(0); k++)
    {
        System.Console.WriteLine($"Слой № {k + 1}");
        for (int i = 0; i < array3D.GetLength(1); i++)
        {
            for (int j = 0; j < array3D.GetLength(2); j++)
            {
                System.Console.Write($"{array3D[k, i, j]}({k},{i},{j}) ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}
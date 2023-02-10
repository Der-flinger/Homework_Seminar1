// Задача 35:Задайте одномерный массив из 123 случайных чисел [0: 1000].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

Console.Clear();

System.Console.WriteLine("Все 123 элемента данного массива ниже\n");
int[] A = newArray(123, 0, 1000);
Console.WriteLine($"Кол-во элементов в пределах [10, 99] равно {GetAmountFromInterval(A)}"); 

int[] newArray(int arrayLength, int minValue, int maxValue)          // функция для заполнения и вывода массива 
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine("\n");
    return array;
}
int GetAmountFromInterval(int[] array)                               // функция для выведения кол-ва элементов из [10, 99]
{
    int i = 0;
    int count = 0;
    while(i < array.Length)
    {
        if (array[i] >= 10 & array[i] <= 99)
        {
            count++;
        }
        i++;
    }
    return count;
}
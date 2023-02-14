// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

Console.Clear();

System.Console.Write("Введите длину массива: ");
int ArrLength = int.Parse(Console.ReadLine()!);                 // задаем переменную в которой длина массива, введенная с клавиатуры
int[] A = newArray(ArrLength);                                  // записываем новый массив в A
int[] resultArray = GetMultiply(A);                             // записываем итоговый массив в resultArray

System.Console.WriteLine("Результирующий массив строкой ниже");
for (int k = 0; k < resultArray.Length; k++)                    // цикл дял выведения на экран в одну строку конечного массива
{
    System.Console.Write($"{resultArray[k]} ");
}
System.Console.WriteLine("");

int[] newArray(int length)                                      // функция для заполнения и выведения случайного массива 
{
    int[] array = new int[length];                              // создаем массив длиной length, которую вводим с клавиатуры
    System.Console.Write("Enter the min Value of array: ");
    int minValue = int.Parse(System.Console.ReadLine()!);
    System.Console.Write("Enter the max Value of array: ");
    int maxValue = int.Parse(System.Console.ReadLine()!);

    System.Console.WriteLine("");
    System.Console.WriteLine("Наш исходный массив строкой ниже");
    for (int i = 0; i < length; i++)                            // цикл для заполнения массива случайными числами
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        System.Console.Write($"{array[i]} ");                   // выводим элементы массива в консоли на одной строке
    }
    System.Console.WriteLine("\n");
    return array;                                               // возвращаем созданный массив
}

int[] GetMultiply(int[] array)                                  // функция заполняющая и возвращающая массив с произведением чисел
{
    int size = array.Length / 2;                                // переменная, где длина нашего результирующего массива
    if (array.Length % 2 == 1) size++;                          
    int[] multiplyArray = new int[size];                        // создаем наш результирующий массив
    int i = 0;
    while( i < size)                                        // цикл для заполнения результирующего массива
    {
        multiplyArray[i] = array[i] * array[array.Length - i - 1];
        i++;
    };
    if (array.Length % 2 == 1) multiplyArray[size - 1] = array[size - 1];
    return multiplyArray;                                       // возвращаем резудбтирующий массив из функции
}
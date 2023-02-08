// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

System.Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine()!);                                    // переменная length для ввода длины массива вручную

int[] array = new int[length];                                                  // новый массив длиной length
FillArray(array);                                                               // заполняем массива
PrintArray(array);                                                              // выведим массив в консоли

void FillArray(int[] a)                                                         // функция для заполнения массива
{
    System.Console.WriteLine("Введите '1', чтобы заполнить массив с клавиатуры или '2', чтобы заполнить массив случайными числами");
    int FillMethod = int.Parse(Console.ReadLine()!); 
    switch (FillMethod)                                                         // переключатель для выбора способа заполнения массива
    {
        case 1:                                                                 // способ заполнения массива с клавиатуры
        {
            for(int i = 0; i < length; i++)
            {
                System.Console.Write($"Введите элемент массива под индексом {i}: ");
                a[i] = int.Parse(Console.ReadLine()!);
            }
            break;
        }

        case 2:                                                                 // способ заполнения массива рандомными числами
        {
            for(int i = 0; i < length; i++)
            {
                a[i] = new Random().Next(-99, 99);
            }
            break;
        }

        default:
        {
            System.Console.WriteLine("Повторите ввод, либо 1, либо 2");
            System.Console.WriteLine("Способ заполнения не выбран, массив будет заполнен нулями");
            break;
        }
    }
}

void PrintArray(int[] a)                                                        // функция для выведения массива в консоли
{
    System.Console.WriteLine("Все элементы в одной строке ниже");
    for(int i = 0; i < length; i++)
    {
        System.Console.Write($"{a[i]} ");
    }
}
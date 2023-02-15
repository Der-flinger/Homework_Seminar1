
//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

System.Console.WriteLine("Введите элементы массива через пробел");
string elements = Console.ReadLine()!;
int[] mainArray = GetStringToInt(elements);
System.Console.WriteLine($"Чисел больше нуля равно {CountNumsAboveZero(mainArray)}");

int[] GetStringToInt(string numsInString)
{
    string[] stringArray = numsInString.Split(" ");
    int[] numArray = new int[stringArray.Length];
    for (int i = 0; i < numArray.Length; i++)
    {
        numArray[i] = int.Parse(stringArray[i]);
    }
    return numArray;
}

int CountNumsAboveZero(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        count += item > 0 ? 1 : 0;
    }
    return count;
}
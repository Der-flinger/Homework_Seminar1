// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


Console.Clear();
System.Console.WriteLine("Введите числа k1, b1, k2, b2 через пробел");
string variables = Console.ReadLine();
int[] varArray = GetStringToInt(variables);
GetIntersectionXY(varArray);

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

void GetIntersectionXY(int[] array)
{
    float k1 = array[0]; float b1 = array[1]; float k2 = array[2]; float b2 = array[3];
    float x = (b2 - b1) / (k1 - k2);
    float y = k1 * x;
    Console.WriteLine($"Точка пересечения находится в координатах x = {x}, y = {y}");
}
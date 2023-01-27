// Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.

Console.Write("Введите первое число: ");        // Задаем первое число
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");        // Задаем второе число
int num2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");        // Задаем третье число
int num3 = int.Parse(Console.ReadLine());

int num12 = Math.Max(num1, num2);       // Сохраняем большее число из первого и второго чисел в num12

Console.Write("Большее из всех трех чисел = ");     // Выводим большее число из всех трех чисел
Console.WriteLine(Math.Max(num12, num3));
// Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");        // Задаем первое число
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");        // Задаем второе число
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
    {
        Console.WriteLine($"{num1} - большее число");
        Console.WriteLine($"{num2} - меньшее число");
    }

else
    {
        Console.WriteLine($"{num2} - большее число");
        Console.WriteLine($"{num1} - меньшее число");
    }
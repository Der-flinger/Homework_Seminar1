// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.Write("Enter our day of week number: ");
int day = int.Parse(Console.ReadLine());

if (day < 1 || day > 7)
{
    Console.WriteLine("еще раз, Введите число от 1 до 7!");
}

else if (day == 6 || day == 7)
{
    Console.WriteLine("этот день выходной, можно спать дальше");
}

else
{
    Console.WriteLine("Это будний день, идем работать");
}
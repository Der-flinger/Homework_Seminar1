// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
System.Console.Write("Вводимое число: ");
int num = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"Сумма цифр цисла = {SummNumbers(num)}");

int SummNumbers(int n)
{
    if (n < 0) n *= -1;
    
    int result = 0;
    while (n > 0)
    {
        result += n % 10;
        n /= 10;
    }
    return result;
}
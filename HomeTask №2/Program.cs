// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

Console.Clear();

Console.Write("Enter our Number: ");
int num = int.Parse(Console.ReadLine());

if ( num > 99 & num < 1000 || num > -1000 & num < -99)
{
    Console.WriteLine($"Третья цифра равна {Math.Abs(num % 10)}");
}

else if (num < 100 & num > -100)
{
    Console.WriteLine("Третьей цифры нет");
}

else if (num > 999)
{
    string numString = num.ToString();
    Console.WriteLine($"Третья цифра равна {numString[2]}");
}

else if (num < -999)
{
    string numString = num.ToString();
    Console.WriteLine($"Третья цифра равна {numString[3]}");
}
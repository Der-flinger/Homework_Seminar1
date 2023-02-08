// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

System.Console.Write("Вводимое число А: ");
int A = int.Parse(Console.ReadLine()!);

System.Console.Write("Вводимая степень В: ");
int B = int.Parse(Console.ReadLine()!);

System.Console.WriteLine($"А в степени В = {PowerAB(A, B)}");

double PowerAB(double a, double b)
{
    double result = Math.Pow(a, b);
    return result;
}

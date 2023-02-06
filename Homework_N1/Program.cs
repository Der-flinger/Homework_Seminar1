// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

Console.Clear();

System.Console.WriteLine("Внимание!!!");
Console.WriteLine("Прога работает только для чисел до 2147483647");
Console.WriteLine("Введите число для проверки");    // Любое число до 2147483647, потому что
int num = int.Parse(Console.ReadLine());            // public const Int32 MaxValue = 2147483647;

int LengthMetod(int arg)                            // Метод для определения длины нашего числа
{
    int count = 0;
    for (int i = arg; arg > 0; i--)
    {
        arg = arg / 10;
        count += 1;
    }
    return count;
}

int numLength = LengthMetod(num);                   // задаем переменную, где длина нашего числа
int[] digits = new int[numLength];                  // задаем массив для цифр нашего числа

for (int i = numLength - 1; i >= 0 ; i--)           // заполняем массив цифрами нашего числа 
{
    digits[i] = num % 10;
    num = num / 10;
}

bool flag = true;                                   // флаг для обозначения палиндромности числа
for (int i = 0; i < numLength / 2; i++)             // проверяем на палиндромность наше число с помощью массива
{
    if (digits[i] != digits[numLength - i - 1]) 
        {
            flag = false; 
            System.Console.WriteLine(flag);
            break;
        }
    // else 
    //     {
    //         flag = false;
    //         System.Console.WriteLine(flag);
    //     }
}

if (flag == true)                                   // вот здесь то флаг и пригодился
    Console.WriteLine("Это число является палиндромом");
else 

    System.Console.WriteLine("Это число не является палиндромом");
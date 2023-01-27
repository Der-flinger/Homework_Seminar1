// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine());

int i = 1;

if (num >= 0)                           // для положительных чисел num
{
    while(i != num + 1)
    {
        if (i % 2 == 0)                                  // программа раб              
            Console.WriteLine(i);
            i += 1;
    }
}

else                                    // для отрицательных чисел num
{
    while(i != num - 1)
    {
        if (i % 2 == 0)                    
            Console.WriteLine(i);
            i -= 1;
    }
}
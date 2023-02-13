// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();
int GetSum(int A)
{
    int count = A;
    int sum = 0;
    while (count > 0)
    {
        sum += count % 10;
        count /= 10;
    }
    return sum;
}

Console.Write("Enter number A: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"сумму цифр в числе {N} равна {GetSum(N)}");
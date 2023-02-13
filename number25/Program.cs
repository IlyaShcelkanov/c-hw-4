// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.Clear();
int GetSum(int A, int B)
{
    int sum = 1;
    for (int i = 0; i < B; i++)
    {
        sum *= A;
    }
    return sum;
}
Console.Write("Enter number A: ");
int N1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter number B: ");
int N2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{N1} в натуральную степень {N2} равна {GetSum(N1, N2)}");
// Задача 29: Напишите программу, которая задаёт массив из 8
// элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int[] GenArray(int range, int min, int max)
{
    int[] array = new int[range];
    for (int i = 0; i < range; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArray(int[] inarray)
{
    for (int i = 0; i < inarray.Length; i++)
        Console.Write($"{inarray[i]}");
}

Console.Write("Enter number range: ");
int rang = int.Parse(Console.ReadLine()!);
Console.Write("Enter number min: ");
int mini = int.Parse(Console.ReadLine()!);
Console.Write("Enter number max: ");
int maxi = int.Parse(Console.ReadLine()!);
int [] array = GenArray(rang, mini, maxi);
PrintArray(array);




// Console.Clear();

// int[] GetArray()
// {
//     int[] array = new int[8];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//     }
//     return array;
// }

// void PrintArray(int[] inarray)
// {
//     for (int i = 0; i < inarray.Length; i++)
//         Console.Write($"{inarray[i]} ");
// }

// int [] array = GetArray();
// PrintArray(array);

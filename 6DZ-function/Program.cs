
// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


Console.WriteLine("введите количество чисел, которые собираететсь ввести");
int M = int.Parse(Console.ReadLine()!);

int[] GetArray(int M1)
{
    int[] array = new int[M1];
    for (int i = 0; i < M1; i++)
    {
        Console.WriteLine("Введите числа, пожалуйста:");
        array[i] = int.Parse(Console.ReadLine()!);     //new Random().Next(min,max);
        Console.WriteLine($"вы ввели {array[i]}");
    }
    return array;
}

int Positive(int[] arraymass)
{
    int count = 0;

    for (int i = 0; i < arraymass.Length; i++)
    {
        if (arraymass[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] result = GetArray(M);
Console.WriteLine("Введенные Вами числа: ");
Console.WriteLine(string.Join(" ", result));

// double[5] M = double.Parse(Console.ReadLine()!);
int result1 = Positive(result);
Console.WriteLine($"Число введеных чисел больше 0 равно {result1}");



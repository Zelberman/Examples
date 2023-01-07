// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Задача №64");

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);

int Factorial(int FactN, int first)
{
    if (first == FactN)
    {
        // Console.Write($"{FactN}");
        return first;
    }
    else 
    {
        if (FactN % 2 == 0)
    {
        Console.Write($"{FactN}, ");
        return Factorial(FactN - 1, 1);
    }
    else 
    {
        return Factorial(FactN - 1, 1);
    }
    }
}
Factorial(N, 1);
// Console.WriteLine($"Факториал числа {N} равен");
// Console.WriteLine (Factorial(N));


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.WriteLine("Задача № 66");
// Console.WriteLine("Введите чилсо M");
// int M = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число N");
// int N = int.Parse(Console.ReadLine()!);

// int Sum (int NumM, int Num N)
// {
//     int Sum = 0;
//     Sum = 

// }


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


Console.WriteLine("Задача № 66");
Console.WriteLine("Введите чилсо M");
int M1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N");
int N1 = int.Parse(Console.ReadLine()!);

int Sum(int NumM, int NumN, int summ)
{
    // int summ = 0;
    if (NumM == NumN)
    {
        Console.Write($"Сумма элементов от M до N равна {summ + NumM}");
        return NumN;
    }
    else
    {
        summ = summ + NumM;
        // Console.WriteLine($"\t{summ}");
        return Sum(NumM + 1, NumN, summ);
    }
}

Sum(M1, N1, 0);
Console.WriteLine();

// Задача № 68
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите чилсо M");
int M2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N");
int N2 = int.Parse(Console.ReadLine()!);

int Akkerman(int M3, int N3)
{
    if (M3 == 0)
    {
        N3 = N3 + 1;
        Console.Write($"результат {N3} ");
        return N3;
    }
    if (N3 == 0 & M3 > 0)
    {    
        return  Akkerman (M3-1, 1); 
    }
    if (M3 > 0 && N3 > 0)
    {
           return Akkerman (M3-1, Akkerman (M3, N3-1));
    }
    return N3;    // return Console.WriteLine ("Недопустимое значение");        
}

Akkerman(M2, N2);




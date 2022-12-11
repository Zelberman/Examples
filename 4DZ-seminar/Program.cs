
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//№1Решение через функцию без цикла.
Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine()!);

int Sum(int A1, int B1)
{
    int powab = 0;
    {
        powab = Convert.ToInt32(Math.Pow(A1, B1));
    }
    return powab;
}
int result = Sum(A, B);
Console.WriteLine(result);

//Решение через функцию с использованием цикла цикла.

Console.WriteLine("Введите число А");
int A2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B");
int B2 = int.Parse(Console.ReadLine()!);

int Sumnumber(int A3, int B3)
{
    int i = 1;
    int sumnum = 1;
    while (B3 >= i)
    {
        sumnum = sumnum * A;
        i++;
    }
    return sumnum;
}

int AB = Sumnumber(A2, B2);
Console.WriteLine(AB);



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
// int[] array = new int[N]

int GetSum(int number)
{
    int plus = 0;
    int sumplus = 0;
    while (number >= 1)
    {
        plus = number % 10;
        number = number / 10;
        sumplus = sumplus + plus;
    }
    return sumplus;
}

Console.WriteLine($"сумма чисел числа {N} равна {GetSum(N)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Задача №29. Задаем массив из 8 Элементов");
int[] U = new int[8];
void Getarray(int[] U1)
{
    int length = U1.Length;
    int position = 0;
    while (position < length)
    {
        U1[position] = new Random().Next(0, 10);
       Console.Write($"{U1[position]}\t");
        position++;
    }
}
Getarray(U);


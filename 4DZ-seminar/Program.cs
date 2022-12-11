
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

int powAB = Sumnumber(A2,B2);
Console.WriteLine(powAB);



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Console.WriteLine("Введите число");
// int N = int.Parse(Console.ReadLine()!);
// int[] array = new int[N]

// int Function(int[] array1, N1)
// {

//     int sum = 0;
//     int index = 0;
//     while (index < N1)
//     {
//         sum = sum + array[index]
//         index++;
//     }
// }



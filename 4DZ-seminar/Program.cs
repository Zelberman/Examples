// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

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






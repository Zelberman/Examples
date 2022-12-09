// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// ConsoleWriteLine("введите число: ");

// int num = int.Parse(Console.ReadLine()!);
// Console.WriteLine($ "Сумма чисел равна = {GetSumNums(num)}");

// int GetSumNums(int number)
// {
//     int sum = 0;
//     while (number>0)
//     {
//         sum = sum + number;
//         number--;
//     }
// return sum;
// }

// Задача 26
// Console.WriteLine("введите число: ");
// int num = int.Parse(Console.ReadLine()!);


// int GetCountNum(int number)
// {
//     int i = 0;
//     while (number>0)
//     {
//         number = number / 10;
//         i++;
//     }
//     return i;
// }
// Console.WriteLine($"Количество чисел в числе = {GetCountNum(num)}");


// Задача 28
// Console.WriteLine("введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// int GetProizvedenie(int number)
// {
//     int i = 1;
//     int M = 1;
//     while (number >= i)
//     {
//         M = i * M;
//         i++;
//     }

//     return M;
// }

// Console.WriteLine($"Ответ = {GetProizvedenie(N)}");

// Задача 30

int N = 8;
int[] arr = new int[N];
void GetArray(int[] array)
{
    int i = 0;
    while (i < 8)

    {
        array[i] = new Random().Next(0, 2);

        Console.Write($" \t {array[i]}");
        i++;
    }
}
GetArray (arr);


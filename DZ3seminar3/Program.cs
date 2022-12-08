//  Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



Console.WriteLine("Задача №19 Решение: 1 вариант: компьютер перебирает \n рэндомные пятизначные числа, пока не находит палиндром.");
int N = 5;
int[] array = { 1, 2, 3, 4, 5 };
int i = 0;
int size = array.Length;
while (array[0] != array[4] || array[1] != array[3])
{
    while (i < N)
    {
        array[i] = new Random().Next(0, 10);
        i++;
    }
    Console.Write($" \t Число {array[0]}");
    Console.Write(array[1]);
    Console.Write(array[2]);
    Console.Write(array[3]);
    Console.Write($"{array[4]} \t - не является палиндромом");
    i = 0;
}
Console.Write($" \t Числооо {array[0]}");
Console.Write(array[1]);
Console.Write(array[2]);
Console.Write(array[3]);
Console.Write($"{array[4]} - является палиндромом \t ");



Console.WriteLine("Задача №19 Решение: 2 вариант: пользователь вводит пятизначные значения.");
Console.WriteLine("Введите пятизначное число");
int M = int.Parse(Console.ReadLine()!);
int M1 = M / 1000;
int M2 = M % 100;

if (M < 0)
    M = -M;

if (M > 99999 || M < 10000)
{
    Console.WriteLine("Число не является пятизначным");
}
else
{
    if (M1 / 10 == M2 % 10)
    {
        if (M1 % 10 == M2 / 10)
        {
            Console.WriteLine("Заданое число - палиндром");
        }
    }
    else
    {
        Console.WriteLine("Это не палендром");
    }

}













































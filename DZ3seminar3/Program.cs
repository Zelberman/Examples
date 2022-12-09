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
Console.Write($" \t Число {array[0]}");
Console.Write(array[1]);
Console.Write(array[2]);
Console.Write(array[3]);
Console.Write($"{array[4]} - является палиндромом \n ");



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

Console.WriteLine("Задача №21");

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты двух точек");
Console.WriteLine("X точки А");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Y точки А");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Z точки А");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("X точки B");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Y точки B");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Z точки B");
int z2 = int.Parse(Console.ReadLine()!);


double length = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));

Console.WriteLine($"длина отрезка равна {length}");


Console.WriteLine("Задача 23");

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N");
int nummmber = int.Parse(Console.ReadLine()!);
// int [] arr = new int [nummmber];
int index = 1;
int sum1 = 1;
Console.WriteLine ($" Таблица кубов: \t числа {nummmber} равна:");
while (index <= nummmber)
    {
        sum1 = index * index * index; 
        Console.WriteLine (sum1);
        index++;
    }









































// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 2");

Console.WriteLine("Введите число 1");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число 2");
int y = int.Parse(Console.ReadLine()!);

Console.WriteLine("Сейчас сравним");

if (x > y)
{
    Console.Write(x);
    Console.WriteLine("- max");

    Console.Write(y);
    Console.Write("- min \n");
}
else
{
    Console.Write(y);
    Console.WriteLine(" - max");

    Console.Write(x);
    Console.WriteLine("-min \n ");
}

Console.WriteLine("Задача 4 ");

Console.WriteLine("Введите 1 число");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите 2 число");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите 3 число");
int c = int.Parse(Console.ReadLine()!);

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine("Максимальное число будет");
Console.WriteLine(max);


Console.WriteLine("Задача 6");


Console.WriteLine("Введите число");
int z = int.Parse(Console.ReadLine()!);

Console.WriteLine("Число является четным?");
if (z % 2 == 0)
{
    Console.Write(z);
    Console.WriteLine(" да, число четное");
}

else
{
    Console.WriteLine(z);
    Console.WriteLine("Нет, Число не четное");
}


Console.WriteLine("Задача 8");

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);

int i = 0;
while (i < n + 1)

    if (i % 2 == 0)
    {
        Console.Write(i);
        i = i + 1;
    }

    else
    {
        i++;
    }


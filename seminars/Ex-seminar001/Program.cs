// See https://aka.ms/new-console-template for more information

Console.WriteLine("Задача 1");

Console.WriteLine("Введите число ");

int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(number*number);




Console.WriteLine("Задача 2");

Console.WriteLine("введите число a");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите число b");
int b = int.Parse(Console.ReadLine()!);

if (b * b == a){
Console.WriteLine("Ответ да");
}
else 
{
    Console.WriteLine("Ответ нет");
}



Console.WriteLine("Задача 3");

Console.WriteLine("введите день недели");
int c = int.Parse(Console.ReadLine()!);

if (c == 1){
Console.WriteLine("Понедельник");
}
else
if (c == 2)
{
    Console.WriteLine("Вторник");
}

else
if (c == 3)
{
    Console.WriteLine("Среда");
}

else
if (c == 4)
{
    Console.WriteLine("Четверг");
}

else
if (c == 5)
{
    Console.WriteLine("Пятница");
}

else
if (c == 6)
{
    Console.WriteLine("Суббота");
}

else
if (c == 7)
{
    Console.WriteLine("Воскресенье");
}

else {
    Console.WriteLine("Ошибка");
}


Console.WriteLine("Задача 5");

Console.WriteLine("Введите число N");

int N = int.Parse(Console.ReadLine()!);
if (N < 0) 
N = -N;
int i = -N;

while(i < N + 1) 
{
Console.WriteLine (i);
i++;
}

Console.Write("Задача 7");

Console.WriteLine("Введите число M");

int M = int.Parse(Console.ReadLine()!);

if (M > 99 & M < 1000) {
    Console.WriteLine(M%10);}
    else Console.WriteLine("не является трехзначным числом");
    
Console.Clear();
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Задача 47");
Console.WriteLine("задайте количество строк");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("задайте количество столбцов");
int colums = int.Parse(Console.ReadLine()!);

double[,] AnyMassive(int row, int colum)
{
    double[,] array = new double[row, colum];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = new Random().NextDouble() * (-100);
        }
    }
    return array;
}

void Print(double[,] printArray)
{

    for (int i = 0; i < printArray.GetLength(0); i++)

    {
        Console.WriteLine();
        for (int j = 0; j < printArray.GetLength(1); j++)
        {
            Console.Write($"\t{Math.Round(printArray[i, j])}");
        }
    }

}

double[,] result = AnyMassive(rows, colums);
// Console.WriteLine($"массив из случайных чисел = {result}");
Print(result);
Console.WriteLine();
// Console.WriteLine (string.Join("", array));


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.WriteLine();
Console.WriteLine("Задача 50");

Console.WriteLine("введите количество строк массива");
int row1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите количество столбцов массива");
int colum1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("значение элемента по горизонтале");
int rowNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите значение элемента по вертикале");
int columNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] GetArray(int newrow, int newcolum)
{
    int[,] arr = new int[newrow, newcolum];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}

void PrintMassive(int[,] printMas)
{
    for (int i = 0; i < printMas.GetLength(0); i++)
    {
        for (int j = 0; j < printMas.GetLength(1); j++)
        {
            Console.Write($"{printMas[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// int[,] resultMas = GetArray(row1, colum1);
// Console 



void indMas(int x, int y, int x1, int y1, int[,] arr2)
{

    if (x > x1 && y > y1)
    {
        Console.WriteLine($"Вывод элемента массива по индексу строка № {rowNumber + 1} столбец № {columNumber + 1}");
        Console.WriteLine(arr2[x1, y1]);
    }
    else
        Console.WriteLine("Введенное число лежит за пределами массива");
}
int[,] arr1 = GetArray(row1, colum1);
PrintMassive(arr1);
Console.WriteLine();
// PrintMassive(GetArray(row1, colum1));
indMas(row1, colum1, rowNumber, columNumber, arr1);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.WriteLine("Задача #52");
Console.WriteLine("Введите количесвто строк массива");
int row3 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива");
int columb3 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное целое число");
int cellMinNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное целое число");
int cellMaxNumber = int.Parse(Console.ReadLine()!);

int[,] GetArray3(int row4, int columb4, int MinNumber, int MaxNumber)
{
    int[,] array3 = new int[row4, columb4];


    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            array3[i, j] = new Random().Next(MinNumber, MaxNumber);
            // Console.Write($"{array3[i,j]}");               
        }
    }

    return array3;
}

void Print3(int[,] printArray3)
{
    for (int i = 0; i < printArray3.GetLength(0); i++)
    {
        for (int j = 0; j < printArray3.GetLength(1); j++)
        {
            Console.Write($"\t\t {printArray3[i, j]}");
        }
        Console.WriteLine();
    }Console.WriteLine();
}

void Sum(int[,] Mas)
{ int num3 = 0;
    for (int j = 0; j < Mas.GetLength(1); j++)
    { double summ = 0;
        for(int i = 0; i < Mas.GetLength(0); i++)
        {summ = (summ + Mas[i,j]);}
        
    Console.WriteLine($"среднее ареф. столбца {num3} равна \t{summ/Mas.GetLength(0)}");
    num3++;}
}

int[,] result3 = GetArray3(row3, columb3, cellMinNumber, cellMaxNumber);
Print3(result3);
Sum(result3);
//end


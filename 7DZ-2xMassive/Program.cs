Console.Clear();
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Задача 47");
Console.WriteLine("задайте количесвто строк");
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

int[,] GetArray(int newrow, int newcolum)
{
    int[,] arr = new int[newrow, newcolum];

    for (int i = 0; i < arr.GetLength(0) ; i++)
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
    Console.WriteLine();}
}

// int[,] resultMas = GetArray(row1, colum1);
// Console 



void indMas (int x, int y, int x1, int y1)
{
    int [,] dataMas = new int[x, y];
    if (x > x1 && y > y1 )
    {
        Console.WriteLine();
        Console.WriteLine(dataMas[x1,y1]);
    }
    else 
    Console.WriteLine ("Введенное число лежит за пределами массива");
}
PrintMassive(GetArray(row1, colum1));
indMas (row1, colum1,rowNumber, columNumber);









// Оформляем всё в методы!****
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Задача №54");

Console.WriteLine("Введите количесвто строк");
int strings = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int columbs = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите ");
// int min = int.Parse("");

int[,] GetArray(int stringsMethod, int columbsMethod)

{
    int[,] massive = new int[stringsMethod, columbsMethod];
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i, j] = new Random().Next(0, 10);
        }
    }
    return massive;
}

void PrintArray(int[,] MassivePrint)
{
    for (int i = 0; i < MassivePrint.GetLength(0); i++)
    {
        for (int j = 0; j < MassivePrint.GetLength(1); j++)
        {
            Console.Write($"\t{MassivePrint[i, j]}");
        }
        Console.WriteLine();
    }
}


int[,] SortMassive(int[,] sort)
{
    int minValue = sort[sort.GetLength(0) - 1, sort.GetLength(1) - 1];
    int stakan = 0;
    for (int i = 0; i < sort.GetLength(0); i++)
    {
        for (int j = 0; j < sort.GetLength(1); j++)
        {
            if (sort[i, j] < minValue)
                minValue = sort[i,j];
                stakan = sort[i,j];
                sort[i,j] = sort[i,sort.GetLength(1)-1] ;
                sort[i, sort.GetLength(1)-1] = stakan;
        // Console.WriteLine(sort[i,j]);
        // Console.WriteLine(sort.GetLength(0)-1);
        }

    }
return sort;
}

int[,] massiveNumbers = GetArray(strings, columbs);
int [,] sortedMassive = SortMassive(massiveNumbers);
PrintArray(massiveNumbers);
Console.WriteLine();
PrintArray(sortedMassive);

















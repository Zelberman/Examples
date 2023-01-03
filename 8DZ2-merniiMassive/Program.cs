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
            // Console.Write($"\t{massive[i, j]}");
        }
        Console.WriteLine();
    }
    return massive;
    // Console.WriteLine();
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

    for (int c = 0; c < sort.GetLength(0) * sort.GetLength(1); c++)
    {
    int stakan = 0;
    for (int i = 0; i < sort.GetLength(0); i++)
    { 
      
        for (int j = 0; j < sort.GetLength(1)-1; j++)
       { int minValue = sort[i, j];
        //    minValue = sort[i,0];
            if (sort[i, j+1] < minValue)
        {               
            stakan = sort[i, j];
            sort[i, j] = sort[i, j + 1];
            sort[i, j + 1] = stakan;
            minValue = sort[i,j];
         }
        // else
        // {
        //     int n = 1;
        //     for (int n = j+1; n<sort.GetLength(1), n++)
        //     if (sort[i, n+1] < sort[i,j])
        //     minValue = sort[i,0];
        // }
            // Console.Write(sort[i, j]);
            // Console.WriteLine(sort[i,j]);
            // Console.WriteLine(sort.GetLength(0)-1);
       }
    }   
    }
    return sort;
}



Console.WriteLine();
int[,] massiveNumbers = GetArray(strings, columbs);

PrintArray(massiveNumbers);
Console.WriteLine();
int[,] sortedMassive = SortMassive(massiveNumbers);
PrintArray(sortedMassive);






// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Задача №56");
Console.WriteLine("Введите число строк");
int str = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов");
int col = int.Parse(Console.ReadLine()!);
if (str != col)
{
int[,] GetArray1(int str1, int col1)
{
    int[,] rectangle = new int[str1, col1];

    for (int i = 0; i < rectangle.GetLength(0); i++)
    {
        for (int j = 0; j < rectangle.GetLength(1); j++)
        {
            rectangle[i, j] = new Random().Next(0, 10);
            // Console.Write(rectangle[i,j]);
        }
        // Console.WriteLine();
    }
    return rectangle;
}

void PrintRectangle(int[,] print1)
{
    for (int i = 0; i < print1.GetLength(0); i++)
    {
        for (int j = 0; j < print1.GetLength(1); j++)
        {
            Console.Write($"\t{print1[i, j]}");
        }
        Console.WriteLine();
    }
}

int Summ(int[,] summer)
{
    int minSum = 100;
    int IndexMin = 100;
    for (int i = 0; i < summer.GetLength(0); i++)
    {   int Index = i;
        string sumstr = "sum";
        int sumString = 0;
        sumstr = sumstr + i;
        Console.Write($"{sumstr} = ");
        for (int j = 0; j < summer.GetLength(1); j++)
        {
            sumString = sumString + summer[i, j];
        }
        Console.WriteLine($"{sumString},");
        
        if (minSum > sumString)
        {
            minSum = sumString;
            IndexMin = i;
        }
        Console.WriteLine($"Cумма значений строки № {Index} равна {sumString}, ");
    }
    return IndexMin;
}
int[,] result = GetArray1(str, col);
PrintRectangle(result);
Console.WriteLine();
// PrintRectangle(GetArray1(str, col));
int resultMinSum = Summ(result);
Console.WriteLine($"минимальная сумма значений находится в строке № {resultMinSum}");
// Console.WriteLine($"Минимальная сумма значений строки равна {minSumString} строки № {i+1}");

}
else
{
    Console.WriteLine("Массив не прямоугольный");
}





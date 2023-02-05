// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int n = 6; // количество элементов в массиве

int[] array = { 0, 2, 4, 6, 8, 10 }; // задаем 6 элементов массива

// сумма элементов массива равна 1-й элемент + последний, поделить на 2  и полученное значеник умножить на количество элементов
int sum = 0;
sum = ((array[0] + array[n - 1]) / 2) * n; // n-1 = 5 (6-й по счету элемент массива)

// второй вариант вычисления: 
int summ = 0;
{
    for (int i = 0; i < n; i++)
        summ += array[i];
}


Console.WriteLine($" сумма элементов массива равна через формулу. 1 вариант  {sum}");
Console.WriteLine($" сумма элементов, посчитанная через цикл. 2 вариант {summ}");
Console.WriteLine("[" + string.Join(",", array) + "]");

Console.WriteLine("Задача на перемножение чисел в двумерном массиве");
Console.WriteLine("Введите количесвто строк и столбцей квадратной матрицы");
int stroka = Convert.ToInt32(Console.ReadLine()!);
int stolb = Convert.ToInt32(Console.ReadLine()!);

if (stolb == stroka)
{
    int[,] GetArray(int stroka1, int stolb1)
    {
        int[,] array2D1 = new int[stroka1, stolb1];
        for (int j = 0; j < stroka1; j++)
        {
            for (int k = 0; k < array2D1.GetLength(1); k++)
            {
                array2D1[j, k] = new Random().Next(0, 10);
            }
        }
        return array2D1;
    }
    
    // int [,] result = GetArray(stroka, stolb);
    
    void PrintArray(int[,] array2D2)
    {
        for (int z = 0; z < array2D2.GetLength(0); z++)
        {
            for (int s = 0; s < array2D2.GetLength(1); s++)
            {
                Console.Write($"\t{array2D2[z, s]}");
            }
            Console.WriteLine("");
        }
    }
    Console.WriteLine("Исходная матрица:");
    Console.WriteLine();
    // PrintArray(GetArray(stroka, stolb));
    Console.WriteLine();
    int [,] GetArrayMatrix = (GetArray(stroka, stolb));
    PrintArray(GetArrayMatrix);

    int[,] GetMultiplication(int[,] array2D3)

    {
        for (int d = 1; d < array2D3.GetLength(0); d++)
        {
            for (int f = 1; f < array2D3.GetLength(1); f++)
            {
                array2D3[d, f] = array2D3[0, f] * array2D3[d, 0];
            }
        }
        return array2D3;
    }

    void PrintMultiplication(int[,] array2D4)
    {
        for (int z = 0; z < array2D4.GetLength(0); z++)
        {
            for (int s = 0; s < array2D4.GetLength(1); s++)
            {
                Console.Write($"\t{array2D4[z, s]}");
            }
            Console.WriteLine("");
        }
    }
    Console.WriteLine($"произведение строк на столбцы квадратной матрицы:");
    Console.WriteLine();
    PrintMultiplication(GetMultiplication(GetArrayMatrix));

}
else
{
    Console.WriteLine("Вы ввели не квадратную матрицу ");
}

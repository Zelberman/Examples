// See https://aka.ms/new-console-template for more information

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.WriteLine("введите количество элементов массива");
int number = int.Parse(Console.ReadLine()!);

int[] funktion(int numbers)   // задаем 1-ю функцию с типом - массив. На вход принимаем число (длина массива)
{
    int[] array = new int[numbers];
    int min = 100;
    int max = 1000;

    int i = 0;
    while (i < numbers)
    {
        array[i] = new Random().Next(min, max);
        i++;
    }

    return array;
}
// int chet(int[] arr1)   // задаем функцию для вычисления четных чисел с типом - массив. 
// На ввод принимаем число (количество элементов массива)
void chet(int[] arr1)     // через void
{
    int count = 0;
    for (int i = 0; i < number; i++)
    {
        if (arr1[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"количество четных чисел в массиве равно = {count}");
    // return count;
}
int[] arr = funktion(number);                // возвращаем функцию задания массива и записываем в переменную arr
Console.WriteLine(string.Join("\t", arr));   // печатаем получившийся массив arr

// int chetsum = chet(arr);                     // возвращаем функцию подсчета четных чисел массива 
// Console.WriteLine($"количество четных чисел в массиве\t - {chetsum}"); // печатаем количество четных чисел.
//
chet(arr);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("введите количество элементов массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[] funct(int num1)
{
    int[] array1 = new int[num1];
    for (int index = 0; index < num1; index++)
    {
        array1[index] = new Random().Next(0, 10);
        // Console.WriteLine($"{array1[index]}");
    }
    return array1;
}

int sumnechet(int[] array2)
{
    int checksum = 0;
    for (int ind = 0; ind < num; ind++)
    {
        if (ind % 2 != 0)
        {
            checksum = checksum + array2[ind];
        }
    }
    return checksum;
}

int[] receive = funct(num);
Console.WriteLine(string.Join(" ", receive));

int receivesum = sumnechet(receive);
Console.WriteLine($"сумма нечетных чисел массива равна {receivesum}");




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("введите количество элементов массива");
int col = int.Parse(Console.ReadLine()!);
double[] ves(int col1)

{
    double[] arraycol = new double[col1];
    for (int count = 0; count < col; count++)
    {
        arraycol[count] = new Random().NextDouble();
    }
    return arraycol;
}
void res(double[] arrayres, int size)
// double res(double[] arrayres, int size)
{
    double maxNumber = arrayres[0];
    double minNumber = arrayres[0];
    for (int count = 1; count < size; count++ )
    {
        if (arrayres [count] > maxNumber)
        {
            maxNumber = arrayres [count];
        }   
         else 
         {
                if (arrayres[count] < minNumber)
                {
                    minNumber = arrayres[count];
                }
         }
    }
    Console.WriteLine ($"максимальное значение - {maxNumber}, минимальное значение - {minNumber}");
    Console.WriteLine ($"разница между max и min значениями составляет- {maxNumber - minNumber}");
}

double[] doub = ves(col);
Console.WriteLine(string.Join("\t", doub));

res(doub, col);



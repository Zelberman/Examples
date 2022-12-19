// See https://aka.ms/new-console-template for more information

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

// КОД
// Console.WriteLine ("Введите трехзначное положительное число");
// int number = int.Parse(Console.ReadLine()!);
// int number1 = 0;
// if (number <100 || number > 999)
// {
//     Console.WriteLine ("вы ввели не трехзначное положительное число");
// }
// else 
// {
//     number1 = number;
//     Console.WriteLine ($"заданное число \t{number1}");
// }



Console.WriteLine("введите количество элементов массива");
int number = int.Parse(Console.ReadLine()!);

int[] funktion(int numbers)   // задаем 1-ю функцию с типом - иассивб на вход принимаем число (длина массива)
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
int chet(int[] arr1)   // задаем функцию для вычисления четных чисел с типом - массив. 
                    // На ввод принимаем число (количество элементов массива)
{
    int count = 0;
    for (int i = 0; i < number; i++)
    {
        if (arr1[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int[] arr = funktion(number);                // возвращаем функцию задания массива и записываем в переменную arr
Console.WriteLine(string.Join("\t", arr));   // печатаем получившийся массив arr
int chetsum = chet(arr);                     // возвращаем функцию подсчета четных чисел массива 
Console.WriteLine($"количество четных чисел в массиве\t - {chetsum}"); // печатаем количество четных чисел.




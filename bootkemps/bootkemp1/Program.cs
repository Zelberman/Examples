using System.Diagnostics;
Console.WriteLine("Задачи буткемп 1");
Console.WriteLine("введите количество элементов массива");
int numbers = int.Parse(Console.ReadLine()!);


int [] GetArray (int numbers)                           // Задачем метод для заполнения массива
{
    int[] GetsArray = new int[numbers];                 // Создаем одноиерный массив с количеством заданных элементов пользователем
    for (int k = 0; k < GetsArray.Length; k++)          // Задаем цикл заполнения массива
    {
         GetsArray[k] = new Random().Next(1,10);        // Заполняем массив рэндомными значениями
    }   
    return GetsArray;                                   // Возвращаем массив из функции
}
int [] Array = GetArray(numbers);                       // задаем новый массив, который равен массиву заполненному в методе
// Console.WriteLine(string.Join("\t", Array)); 
// int [] Array = new int [1, 5, 7, 9, 3, 2, 4, 8, 2, 2];
// int[] Array = { 1, 5, 7, 9, 3, 2, 4, 8, 9, 1 };
int max;
// int second = 0;
int count = 0;
// int first = 0;
int first = Array[0] + Array[1] + Array[2];
max = first;
int index = 0;


Stopwatch sw = new ();
sw.Start();
                                   
for (int i = 0; i < Array.Length - 3; i++)
{
    // first = Array[i] + Array[i + 1] + Array[i + 2];
    int second = Array[i + 1] + Array[i + 2] + Array[i + 3];
    if (second > max)
    {
        max = second;
        index = i+1;
    }
    else
    {
        count = count + 1;
    }

}

sw.Stop();
Console.WriteLine($"time = {sw.ElapsedMilliseconds }");

Console.WriteLine($"сумма максимальных значений равна {max} индекс максимальной суммы чисел равен {index}");
Console.WriteLine($"счетчик постоянства max {count}");














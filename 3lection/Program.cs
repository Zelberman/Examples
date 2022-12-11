
// int Max(int arg1,int arg2,int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// int [] array = {11,12,34,56,67,23,54,76,88};
// int a1 = 4;
// int b1 = 7;
// int c1 = 11;

// int max1 = Max(array[0], array[1], array[3]);
// Console.WriteLine(max1);

// Example
// int find = int.Parse(Console.ReadLine()!);
void Function(int[] arrayN)
{
    int i = 0;
    int len = arrayN.Length;
    while (i < len)
    {
        arrayN[i] = new Random().Next(1, 10);
        i++;
    }
}

void PrintArray(int[] arrayM)
{
    int count = arrayM.Length;
    int position = 0;
    while (count > position)
    {
        Console.WriteLine($"текущее значение массива {arrayM[position]}");
        position++;
    }

}

int[] array = new int[10];   //задали массив из 10 элементов
Function(array);  //заполнили массив числами
PrintArray(array); //напечатали массив

    // if (array[i] == find)
    // {
    //     Console.WriteLine($"Номер числа в массиве {i}");
    // }
    // else
    //     Console.WriteLine("исходное значение в массиве не найдено");
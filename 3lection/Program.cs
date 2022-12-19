


// Задача: создать массив и заполнить его элементами, отличными от нуля, используя функции. 
// Вывести результат на экран
Console.WriteLine("my work");

void test(int[] array1)
{
    int index1 = 0;
    int lenarray1 = array1.Length;
    while (index1 < lenarray1)
    {
        array1[index1] = new Random().Next(1, 10);
        index1++;
    }
}

void printtest1(int[] array1print)
{
    int ind = 0;
    int array1length = array1print.Length;
    while (array1length > ind)
    {

        Console.WriteLine(array1print[ind]);
        ind++;
    }
}

int indexof(int[] array1, int find1)
{
    int position = 0;
    int index1 = 0;
    int lenarray11 = array1.Length;
    while(lenarray11 > index1)
{
    
    if (array1[index1] == find1)
    {
        position = index1;
    }
    index1++;
}
return position;
}
// int numberwork = int.Parse(Console.ReadLine()!);
int[] work = new int [10];
test(work);

printtest1(work);
Console.WriteLine();

int pos = indexof(work, 4);
Console.WriteLine (pos);



















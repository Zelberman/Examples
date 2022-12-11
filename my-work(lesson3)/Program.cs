// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("my work");

int [] array = new int [10];
void test(int[] array1)
{
    int index1 = 0;
    int lenarray1 = array1.Length;
    while (index1 < lenarray1)
    {
        array[index1] = new Random().Next(1, 10);
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
int numberwork = int.Parse(Console.ReadLine()!);
int[] work = new int [numberwork];
test(work);

printtest1(work);
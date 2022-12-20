// See https://aka.ms/new-console-template for more information

void FillArray(int[] collection)

{
    int index = 0;
    int length = collection.Length;

    while (index < length)

    {
        collection[index] = new Random().Next(1, 10);

        index++;

    }

void PrintArray (int[] col) 
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int [] array = new int [10];

}
FillArray (array);
PrintArray (array);




// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int num = new Random().Next(10, 100);

int a1 = num / 10;
int a2 = num % 10;
int max = a1;
if (max < a2)
{
    max = a2;
}

Console.WriteLine("Максимальная цифра в числе" + num + "-->" + max);
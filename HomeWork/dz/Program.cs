// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число 1");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 3");
int number3 = int.Parse(Console.ReadLine()!);

int[] numbers = { number1, number2, number3 };
int size = numbers.Length;
int index = 0;
int max = numbers[0];

while (index < size)
{
    if (max < numbers[index])
    {
        max = numbers[index];
        index = index + 1;
    }
    else
    {
        index++;
    }
}

Console.WriteLine("Максимвльное число =  max");


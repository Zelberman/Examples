Console.Clear();
// Оформляем всё в методы!
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.WriteLine("введите количество чисел, которые собираететсь ввести");
int M = int.Parse(Console.ReadLine()!); // пользователь вводит количество чисел, которые собирается задать.

int[] GetArray(int M1) // задаем метод, который принимает на входе число М1 (М),  а на выходе получаем массив.
{
    int[] array = new int[M1]; // задаем новый массив с количеством элементов в нем, равном М1 (М)
    for (int i = 0; i < M1; i++) // запускаем цикл по заполнению массива пользовательскими значениями
    {
        Console.WriteLine("Введите числа, пожалуйста:"); 
        array[i] = int.Parse(Console.ReadLine()!);   //пользователь вводит количесвто чисел, равное М1 (М) 
        Console.WriteLine($"вы ввели {array[i]}"); // печатаем каждое введенное пользователем число
    }
    return array; // возвращаем полученный массив
}

int Positive(int[] arraymass) // задаем метод, который на входе принимает массив arraymass, а на выходе выдает число.
{
    int count = 0; // задаем счетчик 

    for (int i = 0; i < arraymass.Length; i++) // задаем цикл, который длится до достижения инкремента значения последнего индекса массива
    {
        if (arraymass[i] > 0) // задаем условие внутри цикла, в которм значения элементов массива больше 0.
        {
            count++; // прибавляем счетчик, если значения элементов массива больше 0
        }
    }
    return count; // возвращаем результирующее значение счетчика
}

int[] result = GetArray(M); // задаем массив с именем result, вызываем метод с обрабатываемым числом М
Console.WriteLine("Введенные Вами числа: ");
Console.WriteLine(string.Join(" ", result)); // печатаем обработанный методом GetArray массив

int result1 = Positive(result); // задаем переменную result1, которая равна значению count, который мы вернули из
                                // метода Positive введя в него массив result
Console.WriteLine($"Количество введенных чисел больше 0 равно {result1}"); // печатаем результат result1.



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1*x + b1 = k2*x+b2
// x*(k1-k2) = b2 - b1
// x = (b2 - b1) / (k1 - k2)

Console.WriteLine ("уравнение y = k1 * x + b1, y = k2 * x + b2");

Console.WriteLine ("введите b1");
double b1 = int.Parse(Console.ReadLine()!);

Console.WriteLine ("введите b2");
double b2 = int.Parse(Console.ReadLine()!);


Console.WriteLine ("введите множитель k1");
double k1 = int.Parse(Console.ReadLine()!);

Console.WriteLine ("введите множитель k2");
double k2 = int.Parse(Console.ReadLine()!);

Console.WriteLine ("вычисляем значение X, где пересекаются прямые.");
double x = (b2 - b1)/(k1 - k2);
Console.WriteLine (x);
double  GetY (double kk, double xx, double bb)
{
    double y = kk * xx + bb;
   
    return y;
}

double y1 = GetY(k1, x, b1);
double y2 = GetY(k2, x, b2);

Console.WriteLine ($"координаты первой точки первой прямой x1 = {x}, y1 = {y1}");
Console.WriteLine ($"Координаты первой точки второй прямой x2 = {x}, y2 = {y2}");

















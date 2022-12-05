Console.WriteLine("Задача №10");
//  int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Компьютер вводит рэндомное число, если число будет трехзначным, то \nМы вычислим второе значение этого числа");

//Если требуется, чтобы число вводил пользователь, то закомментируйте строчку №3 и раскомментируйте строку №2 


int number = new Random().Next();
Console.WriteLine($"вы ввели число - {number}");

int number1 = (number % 100);
int number2 = (number1 / 10);
if (number > 99 & number < 1000)
{
    Console.Write($"второе число равно - {number2} \n");
}

else
{
    Console.Write("Вы ввели не трехзначное число \n");
}



Console.Write("Задача №13\n");

Console.WriteLine("Введите любое число");

//Если требуется, чтобы число вводил пользователь, то закомментируйте строчку №33 и раскомментируйте строку №34

//  int number = int.Parse(Console.ReadLine()!);

int number3 = new Random().Next();
//int number3 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"заданное число - {number3}");




if (number3 < 0)
    number3 = -number3;

while (number3 > 999)

{
    number3 = number3 / 10;
}

if (number3 < 100)
{
    Console.WriteLine("у введенного значения Нет третьего числа");
}

if (number3 > 99 & number3 < 1000)
{
    Console.WriteLine($"третье число будет равно - {number3 % 10}");
}


Console.WriteLine("Задача №15");

int[] array = { 1, 2, 3, 4, 5, 6, 7 };
int size = array.Length;
Console.WriteLine($"Количество дней в неделе {size}");
Console.WriteLine("Введите порядковый номер дня недели");
int number4 = int.Parse(Console.ReadLine()!);



int num1 = array[0];
int num2 = array[1];
int num3 = array[2];
int num4 = array[3];
int num5 = array[4];
int num6 = array[5];
int num7 = array[6];

// int Monday = array[index(0)];
// string Monday = 1;
// int num0 = int.Parse(Mondey);
// Console.WriteLine($"Monday");



int index = 0;
if (number4 > 0 & number4 < 7)
{
    if (number4 == num1)
    { Console.WriteLine("monday"); }
    if (number4 == num2)
    { Console.WriteLine("Tueday"); }
    if (number4 == num3)
    { Console.WriteLine("Wednesday"); }
    if (number4 == num4)
    { Console.WriteLine("Thursday"); }
    if (number4 == num5)
    { Console.WriteLine("Friday"); }
    if (number4 == num6)
    { Console.WriteLine("Saturday"); }
    if (number4 == num7)
    { Console.WriteLine("Sunday"); }
}
else

    Console.WriteLine("Не верный ввод порядкового номера недели");





// See https://aka.ms/new-console-template for more information
int NumberA = new Random().Next(1,10); // случайное число 1-9 (max-1)
Console.WriteLine(NumberA);
int NumberB = new Random().Next(0,10); // случайное число от 0 до 10
Console.WriteLine(NumberB);
int result = (NumberA + NumberB) ;
Console.WriteLine(result);



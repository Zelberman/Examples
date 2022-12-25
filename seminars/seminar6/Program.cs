// See https://aka.ms/new-console-template for more nformaton
// Console.WrteLne("Hello, World!");
//задача 39
// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

//ReversArray1(array);



// nt[] array = GetArray(9, 0, 10);                - вызов функции GetArray
// Console.WrteLne(strng.Jon(" ", array));         - печать полного массива
// Console.WrteLne();                              - отступ    
// nt[] reversArray = ReversArray2(array);         - вызов функции revers array

// Console.WrteLne(strng.Jon(" ", reversArray));

// nt[] GetArray(nt sze, nt mnValue, nt maxvalue)
// {
//     nt[] res = new nt[sze];
//     for (nt  = 0;  < sze; ++)
//     {
//         res[] = new Random().Next(mnValue, maxvalue + 1);
//     }
//     return res;
// }

// vod ReversArray1(nt[] nArray)
// {
//     for (nt  = 0;  < nArray.Length / 2; ++)
//     {
//         nt k = nArray[];
//         nArray[] = nArray[nArray.Length - 1 - ];
//         nArray[nArray.Length - 1 - ] = k;
//     }
// }

// nt[] ReversArray2(nt[] nArray)
// {
//     nt[] result = new nt[nArray.Length];
//     for (nt  = 0;  < nArray.Length; ++)
//     {
//         result[] = nArray[nArray.Length - 1 - ];
//     }
//     return result;
// }






// // мой вариант 
Console.WriteLine("введите число элементов массива");
int number1 = int.Parse(Console.ReadLine()!);
int[] array1 = new int[number1];
// Console.WrteLne(strng.Jon(" ", array));
int mnValue = 0;
int maxValue = 9;
int i = 0;
Console.WriteLine();
while (i < number1)
{
    array1[i] = new Random().Next(mnValue, maxValue); // рэндомное заполнение массива
    Console.WriteLine(array1[i]);
    i++;
}
Console.WriteLine("Реверс массива");
int ind = 0;
while (ind < number1 / 2)
{
    int stakan = array1[ind]; // отправляем 1 цифру массива в стакан
    array1[ind] = array1[array1.Length - 1 - ind]; // перезаписываем последний элемент в первый и т.д.
    array1[array1.Length - 1 - ind] = stakan; // в последний элемент массива записываем первый из стакана.
  
    ind++;
}

Console.WriteLine(string.Join("\t", array1)); //- печать всего массива

//   Console.WriteLine();
//     Console.WriteLine(array1[ind]);
























// //  тип метода ИмяМетода (парам1, парам2, ... парфмН)
// // a, и - 2 числа sign - строка для знача операции
// double Calculate (double a, double b, string sign)
// {
//     if (sign == "+")
//     {
//         return a + b; // сумма
//     }
//     else if (sign == "-")
//     {
//         return a - b; // вычитание
//     }
//     else if (sign == "*")
//     {
//         return a * b;
//     } 
//     else if (sign == "/")
//     {
//         return a / b; // деление
//     }
//     else 
//     {
//         Console.WriteLine("Введен неизвестный знак");
//          return 0; 
//     }
// } 

// //  вызов метода / функции
// Console.WriteLine (Calculate(12,3,"/"));
// Console.WriteLine (Calculate(12,3,"*"));
// Console.WriteLine (Calculate(12,3,"+"));
// Console.WriteLine (Calculate(12,3,"-"));
// Console.WriteLine (Calculate(12,3,","));

// //  Задача 1. Задайте массив из N чисел и вывидите те которые оканчиваются на 1 и делятся на 7

// int [] CreateArray (int size)
// {
//     int [] array = new int[size]; // массив на size элементов все элементы равны 0
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 101);
//     }
//     return array;
// }

// int GetCount (int [] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 7 == 0 && arr[i] % 10 == 1)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// // Вызываем метод 
// Console.Write ("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int [] res = CreateArray(N);

// Console.WriteLine($"Maccив: [ {string.Join("; ", res)} ]");
// Console.WriteLine($"Результат:  {GetCount(res)}");
// // int count = GetCount(res);

//  Задача 3. 
int [] CreateArray (int size)
{
    int [] array = new int[size]; // массив на size элементов все элементы равны 0
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

// int ConvertArrayToInteger (int size)
// {

// }
//  if (int.TryParse(text, out number)) // определяет что в строке только цифры а не букты

int N = Convert.ToInt32(Console.ReadLine());
int [] res = CreateArray(N);

Console.WriteLine($"Maccив: [ {string.Join("; ", res)} ]");
// int[] arr = new int[5]; // создал массив, выделил для массива память на 5 целвых чисел
// arr[0] = 5; // заполняет элменты массива значениями
// arr[1] = 8;
// arr[2] = 2;
// arr[3] = 3;
// arr[4] = 4;
// Console.WriteLine(arr[0]); // выводим содержимое массива в терминал
// Console.WriteLine(arr[1]);
// Console.WriteLine(arr[2]);
// Console.WriteLine(arr[3]);
// Console.WriteLine(arr[4]);
// // Console.WriteLine(arr[5]); выход за границы массива - будет предупреждение


// int[] arr2 = new int[5] { 2, 4, 7, 8, 9 }; // заполнение массива сразу присоздании

// int[] arr3 = { 1, 2, 3, 4, 5 }; // без указания количества элементов массива когда число элементов фиксировано
// //  arr = [1,2,3,4,5] - синтаксис для Python

// int N = 10;
// int[] arr = new int[N];
// int i = 0; // переменная-счетчик
// while (i < arr.Length)
//     {
//        arr[i] = i+1;
//         Console.Write($"{arr[i]} ");
//         i++;  
//     }


// int[] array = {1,2,3,4,5,6,7,8,9,10};
// int i = 0;

// while (i < array.Length)
// {
//     if (array[i] % 2 == 0)
//     {
//         Console.Write(array[i] + " ");
//     }
//     i = i + 1;
// }

int n = 5;
int[] array = { 22, 85, 19, 17, 55 };
int i = 0;
int max = array[0];
while (i < n)
{
    if (array [i] > max)
    {
        max = array [i];
    }
    i++;
}
Console.WriteLine(max);

max = array[0];
for(int j =0; j < n; j++ )
{
     if (array [j] > max)
    {
        max = array [j];
    }
}
Console.WriteLine(max);

foreach(int e in array)
{
     if (e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);


// // счетный цикл for
// int [] array = {5,10,15,18,25};
// for (int i = 0; i < array.Length; i++ )
//     {
//         Console.Write($"{array[i]} ");
//     }

// // цикл foreach перебор без индекса для всех элементов не меняет содержимое цикла
// int [] array = {1,2,3,4,5};
// foreach (int e in array)
// {
//     Console.Write(e);
// } 

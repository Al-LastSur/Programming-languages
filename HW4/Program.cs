// // Task 1. Programme constantly asks to enter integer numbers thourhg console.
// //  programme stops only if you input "q" or the sum of figures in number is even

// int dataSum (string result) // метод суммы цифр числа
// {
//     // int number = Convert.ToInt32(dataInput); // альтернативный вариант трансформации в число
//     int number = int.Parse(result);
//     int sum = 0;
//     if (int.TryParse(result, out number))
//     {
//     while (number > 0 )
//     {
//         sum = sum + number % 10;
//         number = number / 10; 
//     }
//     }
//     return sum;
// }
//     // Вывод результата

// while (true) // бесконечный цикл
// {
//     Console.Write ("Введите число: ");
//     string line = Console.ReadLine();

//     if (line == "q")
//         {
//         Console.WriteLine("Выход из программы");
//         break;
//         }
//     if (int.TryParse (line, out int number))
//     {
        
//         if (dataSum(line) % 2 == 0 )
//         {
//         Console.WriteLine("Выход из программы");
//         break;
//         }
//     }
//     else 
//     {
//         Console.WriteLine("Некорректный ввод. Введите число, либо q для выхода");
//     }

// }

// // Task 2. Set an array with random thre-digit numbers and it counts amount ogf those are even


// int [] CreateArray (int size)
// {
//     int [] array = new int[size]; // массив на size элементов все элементы равны 0
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//     }
//     return array;
// }
// int GetCount (int [] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }
// // Вывод результата
// Console.Write ("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int [] res = CreateArray(N);
// Console.WriteLine($"Maccив: [ {string.Join("; ", res)} ]");
// Console.WriteLine($"Результат:  {GetCount(res)}");


// // Task 3. Set an array where the numbers just change their place in an array so that the first is the last, etc.

// int [] ChangePlace ( int [] array)
// {
//     int[] res = new int [array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         res [i] = array[(array.Length-1) - i];
//     }
//     return res;
// }
// // Вывод результата
// int [] numbers = {25, 1, 3, 5, 6, 7, 8, 98, 102};
// Console.WriteLine($"Массив перевернут: [ {string.Join("; ", ChangePlace(numbers))} ]");
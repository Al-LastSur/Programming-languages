// // Task 1. Programme constantly asks to enter integer numbers thourhg console.
// //  programme stops only if you input "q" or the sum of figuers in number is even

string dataInput (string line) // метод ввода данных
{
    Console.Write ("Введите число: ");
    line = Console.ReadLine();
    return line;
}
int dataSum (string line)
{
    dataInput(string line);
    int number = Convert.ToInt32(line);
    int sum = 0;
    while (number > 0 )
    {
        sum = sum + number % 10;
        number = number / 10; 
    }
    return sum;
}

    // Вывод результата

while (true) // бесконечный цикл
{
    dataInput(line);
    if (dataInput(line) == "q" || dataSum(line) % 2 == 0 )
    {
        Console.WriteLine("Выход из программы")
        break;
    }
}


// SumNumbers(number);


    





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


// Task 3. Set an array where the numbers just change their place in an array so that the first is the last, etc.

// // Task 1. Use recursion. Print all numbers in between M and N 
// string PrintResult(int m, int n)
// {
//         if (m > n)
//         {
//             return "Некорретный ввод";
//         }
        
//         else if (m == n)
//         {
//             return m.ToString() + n.ToString();
//         }
//         else
//         { 
//             return m.ToString() + PrintResult(m+1, n);
//         }
// }

// // output result
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Результат: {PrintResult(M, N)}");


// // Task 2. Use recursion. Calculate Ackerman Function 
// int AckermanFunction( int m, int n)
// {
// if (m < 0 || n < 0) return 0; // работает только длля положительных чисел
// if (m == 0) // если n = 0
// {
//     return n +1;
// }
// else if (n == 0) // если m = 0
// {
//     return AckermanFunction(m-1, 1);
// }
// else // если m > 0 и n > 0
// {
//     return AckermanFunction(m-1, AckermanFunction(m, n-1));
// }
// }
// // output result
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Резульат: {AckermanFunction(M, N)}");

// Alternmative solution from internet - how to prevent stack overflow efrror
// even online calculator cannot provide A(4,4) = stack overflow error
// Check online calculator https://kimbweta-ackermann-calculator.netlify.app/
    // int Ackermann(int m, int n)
    // {
    //     if (m == 0)
    //     {
    //         return n + 1;
    //     }
    //     else if (n == 0)
    //     {
    //         return Ackermann(m - 1, 1);
    //     }
    //     else
    //     {
    //         return TailAckermann(m - 1, n, 1);
    //     }
    // }

    // int TailAckermann(int m, int n, int result)
    // {
    //     if (m == 0)
    //     {
    //         return result + n;
    //     }
    //     else if (n == 0)
    //     {
    //         return TailAckermann(m - 1, 1, result);
    //     }
    //     else
    //     {
    //         return TailAckermann(m - 1, Ackermann(m, n - 1), result);
    //     }
    // }
    //     int m = 4;
    //     int n = 20;
    //     Console.WriteLine($"Ackermann({m}, {n}) = {Ackermann(m, n)}");

// // Task 3. Use recursion. Create random array. Print all its elements starting from the end.
int[] CreateArray(int size, int[] array = null, int currentIndex = 0) // int[] array = null - to create new array only once
{
    if (array == null) // for not to create new array every time
    {
       array = new int [size]; 
    }
    if (currentIndex < size)
    {
        Random rnd = new Random();
        array[currentIndex] = rnd.Next(1000); // range of numbers in array
        return CreateArray(size, array, currentIndex + 1);
        // return array;
    }
    else
    {
        return array;
    }    
}
int[] ReverseArray (int[] array)
{
    array = array.Reverse().ToArray();
    return array;
}
// output results
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArray(size);
string ArrayAsString = string.Join (", ", array);
Console.WriteLine($"Созданный массив: {ArrayAsString}");
Console.WriteLine($"Перевернутый массив: {string.Join(", ", ReverseArray(array))}");
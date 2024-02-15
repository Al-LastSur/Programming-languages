// //  Task 1. Solve task (a*b)/(c+d) with help of a function
// double CalculateFormula(int a, int b, int c, int d)
// {
//     int nomenator = a * b;
//     double denomenator = c + d;
//     double result = nomenator / denomenator;
//     return result;
// }

// double result = CalculateFormula(1, 2, 3, 4);

// Console.WriteLine(result); 

// // Task 2. Solve task to print squeares of numbers
// void PrintSquares (int limit)
// {
//     int i = 1;
//     while (i<= limit)
//     {
//         Console.Write($"{i*i} ");
//         i++;
//     }
// }

// PrintSquares(5); 
// PrintSquares(10); 
// PrintSquares(15);

// // Task3. Make all even numbers in an array equal zero
// void ZeroEvenElements(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             arr[i] = 0;
//         }
//     }
// }
// void PrintArray(int[] arr)
// {
//     foreach (int e in arr)
//     {
//         Console.Write($"{e} ");
//     }
// }

// int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
// ZeroEvenElements(array);
// PrintArray(array);


// // HW at the lecture
// int n = 10;
// int [] array = new int [n];
// int i = 0;
// void FillArray (int [] array)
// {
//     while (i < n)
//     {
//         array [i] = i+1;
//     }
// }
// void PrintArray(int [] array)
// {
//     while (i < n)
//     {
//         Console.Write ($"{array[i]} ");
//     }
// }
// void GetSumOfElements(int [] array)
// {
//     int sum = 0; 
//     while (i < n)
//     {
//         sum = sum + array[i];
//     }
// }
// void GetProductOfElements(int [] array);
// {
//     while(i < n)
//     {
//         int product = 1;
//         product = GetProductOfElements * array[i];
//     }
// }

// int n = 10;
// int [] array = new int [n];
// FillArray(array);
// PrintArray(array);
// int sum = GetSumOfElements(array);
// int product = GetProductOfElements(array);
// Console.WriteLine ($"Сумма элементов массива: {sum}");
// Console.WriteLine ($"Произведение элдементов массива: {product}");

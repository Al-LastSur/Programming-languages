// // Task 1. Create two-dimension array of char-type symbols. Print a Line with those symbols.
// char[,] CreateCharMatrix(int rows, int columns) // двумерный массив [,] метод создания мат
// {
//     char[,] array = new char[rows, columns]; // строки столбцы
//     Random rnd = new Random();
//     int minAscii = 48; // range of digits, letters of lower and higher register
//     int maxAscii = 122;
//     for (int i = 0; i < array.GetLength(0); i++) // сначала в строчку rows = matr.GetLength(0)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // теперь в столбцы  columns = mart.GetLength(1)
//         {
//             array[i, j] = (char)rnd.Next(minAscii, maxAscii);
//         }
//     }
//     return array;
// }

// string CharMatrixLine (char[,] chars)
// {
// string result = string.Empty;
// for (int i = 0; i < chars.GetLength(0); i++)
// {
//     for (int j = 0; j < chars.GetLength(1); j++)
//     {
//         result = result + chars[i, j];
//     }
// }
// return result;
// }

// void PrintMatrix(char[,] matr) // used just to coimpare the way it looks in an array and a string
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // проход по строчкам двумерного массива
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // проход по столбцам двухмерного массива
//         {
//             Console.Write($"{matr[i, j]}\t"); // \t - 4 пробела между элементами 
//         }
//         Console.WriteLine(); // перенос на новую строку
//     }
// }

// // output results
// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// char[,] chars = CreateCharMatrix(rows, cols);
// // PrintMatrix(chars); uncomment if you want to see the matrix
// Console.WriteLine($"Two-dimention char matrix in one line: {CharMatrixLine(chars)}");


// Task 2. Create a string with latin symbols in higher and lower cases.
// Print a string wher all uppercase characters replaced with lowercase characters.

// output results


// Task 3. Create random string And check if it is a polyndrome or not.

// output results

// Task 4. (optional) Create a string with words separated by spaces. pring another string where all the words have reverse order.
// Mind the spaces

// output results

// // Task 1. Create two-dimension array of char-type symbols. Print a Line with those symbols.
// char[,] CreateCharMatrix(int rows, int columns) // двумерный массив [,] метод создания мат
// {
//     char[,] array = new char[rows, columns]; // строки столбцы
//     Random rnd = new Random();
//     int minAscii = 48; // ASCII range of digits, letters of lower and higher register
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

// void PrintMatrix(char[,] matr) // used just to compare the way it looks in an array and in a string
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

// // Task 2. Create a string with latin symbols in higher and lower cases.
// // Print a string where all uppercase characters replaced with lowercase characters.

// string GenerateRandomString(int length) // Запрос у пользователя длины строки
// {
//  Random random = new Random();
//  const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"; // latin ABC
//  char[] randomChars = new char[length];

//  for (int i = 0; i < length; i++)
//  {
//      randomChars[i] = chars[random.Next(chars.Length)];
//  }
//  return new string(randomChars);
// }

// string ConvertToUpperToLower(string input)
// {
//   char[] charArray = input.ToCharArray();

//   for (int i = 0; i < charArray.Length; i++)
//     {
//         if (char.IsUpper(charArray[i])) // Check if it's upper case
//             {
//                 charArray[i] = char.ToLower(charArray[i]); // Transform upper into lower case
//             }
//     }

//     return new string(charArray);
// }
// // Output results
// Console.WriteLine("Введите длину строки:");
// int length = Convert.ToInt32(Console.ReadLine());
// string randomString = GenerateRandomString(length);
// Console.WriteLine("Случайная строка: " + randomString);
// string convertedString = ConvertToUpperToLower(randomString);
// Console.WriteLine("Преобразованная строка: " + convertedString);

// // Task 3. Create random string And check if it is a polyndrome or not.
// bool CheckPalindrome(string str)
// {
//     int left = 0;
//     int right = str.Length - 1;
//     while (left < right)
//     {
//         if (str[left] != str[right])
//         {
//             return false;
//         }
//         left++;
//         right--;
//         }
//         return true;
// }
// // output results
// Console.Write("Введите строку: ");
// string inputString = Console.ReadLine();
// int length = inputString.Length;
// Console.WriteLine($"Длина строки: {length}");
// bool isPalindrome = CheckPalindrome(inputString);
// if (isPalindrome)
// {
//     Console.WriteLine("Данная строка является палиндромом.");
// }
// else
// {
//     Console.WriteLine("Данная строка не является палиндромом.");
// }



// Task 4. (optional) Create a string with words separated by spaces. pring another string where all the words have reverse order.
// Mind the spaces

string ReverseWords(string input)
{
    string[] words = input.Split(' '); // Split into words
    Array.Reverse(words); // Change array indexes
    return string.Join(" ", words); // Unite words once again
}



// output results
Console.WriteLine("Введите строку со словами через пробел:");
string inputString = Console.ReadLine();
string reversedString = ReverseWords(inputString);
Console.WriteLine("Строка с перевёрнутыми словами:");
Console.WriteLine(reversedString);



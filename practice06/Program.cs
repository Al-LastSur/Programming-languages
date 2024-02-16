// // task 1. crreate char[] array. print Line with symbols of the array
// string GetStrFromCharArray (char[] array)
// {
//     // string result = ""; better way is lower
//     string result = string.Empty; // the same as ""
//     foreach (char symbol in array) // takes all chars from array
//     {
//         result += symbol;
//     }
//     return result;
// }

// // Outout result
// char[] chars = {'a', 'b', 'c', 'd', 'e','2','1'}; // for char use 'a' for string use "a"
// Console.WriteLine($"Array: [{string.Join("; ", chars)}]");
// string res = GetStrFromCharArray(chars);
// Console.WriteLine(res);

// // Task 2. Take a string transform into an array of chars. Prin the result.

// char[] TransformStrToCharArray(string str)
// {
//     char [] chars = new char[str.Length];
//     for (int i = 0; i < str.Length; i++)
//     {
//         chars[i] = str[i];
//     }
//     return chars;
// }

// // Outout result
// string str = "Hello, World!";
// Console.WriteLine($"String: {str}"); 
// char[] chars = TransformStrToCharArray(str);
// Console.WriteLine($"Array: [{string.Join("; ", chars)}]");

// // Task 3. ReadLine from Console with lowercase latin characters. Count for vowels in a line. Pring result to the console.
// int GetCountVowels(string line)
// {
//     string vowels = "aeiouy";
//     int vowelsCount = 0;
//     foreach (char symbol in line)
// {
//     foreach (char vowel in vowels)
//     {
//         if (symbol == vowel)
//         {
//             vowelsCount++;
//             break; // if you found one vowel break the loop
//         }
//     } 
// }
// return vowelsCount;
// }

// Console.Write("Enter a string: ");
// string input = Console.ReadLine();// check for lower and upper case it is different for c#
// input = input.ToLower(); // turn the string into lower case
// Console.WriteLine($" Строка: {input}");
// Console.WriteLine($" В строке {input} количество гласных в нижнем регистре: {GetCountVowels(input)}");
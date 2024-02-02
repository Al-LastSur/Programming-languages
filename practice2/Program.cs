// // practical tasks at the seminar on 29/01/24
// // Task 1. input three-digit number and delete second digit out of it
// Console.Write("Введите трехзначное число: "); 
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 99 && number < 1000)
//    {
//     int firstDigit = number / 100;
//     int thirdDigit = number % 10;
//     int result = firstDigit * 10 + thirdDigit;
//     Console.WriteLine($"результат {result}");
//    }
// else
// {
//     Console.WriteLine($"вы вышли за пределы допустимых значений");
// }


// // Task 2 Input three-digit mnumber and recieve the result of the second digit raised to the power of the thoird digit
//  Console.Write("Введите трехзначное число: "); 
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 99 && number < 1000)
//     {
//         int thirdDigit = number % 10;
//         int secondDigit = number / 10 % 10;
//         int result = (int)Math.Pow(secondDigit, thirdDigit);
//         Console.WriteLine($"{secondDigit} ^ {thirdDigit} = {result}");
//     }
// else
// {
//     Console.WriteLine($"вы вышли за пределы допустимых значений");
// }


// // Task 3. Input two numbers and identify if the first number can be devisible by the factor of the second number
// Console.Write("Введите первое число: "); 
// int numberOne = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: "); 
// int numberTwo = Convert.ToInt32(Console.ReadLine());
// if (numberOne % numberTwo == 0)
// {
//     Console.Write($"{numberOne} кратно {numberTwo}");
// }
// else
// {
//     Console.Write($"{numberOne} не кратно {numberTwo}");
// }


// // Task 4. Identify the thrid-digit from the end or inform if there is none
// Console.Write("Введите число: "); 
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 100)
//     {
//      int result = number / 100 % 10;
//     Console.Write($"Третий разряд {number} является {result}");      
//     }
// else
//     {
//     Console.Write($"Третьего разряда в {number} нет");
//     }



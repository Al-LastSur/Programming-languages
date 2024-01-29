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


Task 3. 
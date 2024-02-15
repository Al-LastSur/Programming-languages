// // Рекурсия - выхов метода внутри себя
// int FinfFactorial(int n)
// {
//     // Baasic case - to stop recursion
//     if (n == 1) return 1;
//     //Recursion case - to call for recutrsion inside the funcction  
//     return n * Findfactorial(n - 1);
// }

// // Task 1. Напишите программу, которая будет принимать на вход число и
// // возвращать сумму его цифр.

// int SumOfDigits(int n)
// {
//     if (n == 0) return 0;
//     int res = (n % 10) + SumOfDigits(n / 10);
//     return res;
// }
// int arg = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumOfDigits(arg)); //Console


// Task2 . Выводим строку с числами от 1 до n
{
if (start == end) 
{
    Console.Write(start);
    return; // пустой return для void допустим
}
Console.Write(start+ " ");
PrintLine(start + 1, end);
}

PrintLine(1,5);
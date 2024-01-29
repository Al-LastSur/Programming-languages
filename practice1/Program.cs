// int number1 = 25;
// int number2 = 5;
// if (number1 == number2 * number2) 
// {
//     Console.WriteLine("TRUE");
// }
// else 
// {
// Console.WriteLine("FALSE");
// }  

// int number3 = 9;
// int number4 = -3;
// if (number3 == number4 * number4)
// {
//     Console.WriteLine("TRUE");
// }
// else
// {
//     Console.WriteLine("FALSE");
// }  


// int number5 = -3;
// int number6 = 9;
// if (number5 == number6 * number6) 
// {
//     Console.WriteLine("TRUE");
// }
// else
// {
//     Console.WriteLine("FALSE");
// }  

// Console.Write("Введите целое число с консоли: ");
// int test = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(test);


// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// int N = 4; // отобразить все числа от N до -N
// int negN = -N;
// while (negN <= N)
// {
//     Console.Write(negN + " ");
//     negN++; // increment N-- decrement
// }
    
// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17
// "&&" "И" 

int number = 357;
if (number >= 100 && number<= 999)
{
    int number1 = number / 100;
    int number2 = number % 10;
    int res = number1 + number2;
    Console.WriteLine("Result " + res);
}
else
{
    Console.WriteLine("Ошибка");
}
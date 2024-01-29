// HW after Seminar Simple Algorithms
// To switch between Task comment(ctrl+/) and uncomment(ctrl+/) those to check.

// // Task 1. Write program where you input a number and it must be checked if this program is 7-fold and 23-fold at the samne time
// Console.Write("Введите число сконсоли: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine("Число кратно и 7 и 23"); // to check the correct answer input 144, 161, 322
// }
// else 
// Console.WriteLine("Число кратно и 7 и 23"); // to check the correct answer input any other and you may be lucky

// // Task 2. Identify the coordinate quarter for a dot inside the system of coordinates (X,Y)
// // Note: The dot coordinates are never (0,0)
// Console.Write("Введите координаты точки на оси координат X:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты точки на оси координат Y:");
// int y= Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0)
// {
//     Console.WriteLine("Точка находится в Первой четверти оси координат");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("Точка находится во Второй четверти оси координат");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("Точка находится в Третьей четверти оси координат");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("Точка находится в Четвертой четверти оси координат");
// }
// else
//     Console.WriteLine("Точка стоит по координатам 0,0");

// // Task3. Show the largest figure of a number within 10 to 99.
// Console.Write("Введите число в диапазоне от 10 до 99 включительно: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 100) 
// {
//     int firstFigure = number / 10;
//     int secondFigure = number % 10;

//     if (firstFigure > secondFigure)
//     {
//     Console.WriteLine(firstFigure + " больше " + secondFigure); // output through concatination
//     }
//     else
//     Console.WriteLine($"{secondFigure} больше {firstFigure}"); // output through interpolation
// }
// else
// Console.WriteLine("Вы вышли за диапазон допустимых значений");

// Task 4. Input a number and see all its figures in a list

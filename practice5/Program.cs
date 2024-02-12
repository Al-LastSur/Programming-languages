// //  task 1. двумерные массивы // ноль это четное число?
// int[,] CreateMatrix(int rows, int columns) // двумерный массив [,] метод создания матрицы 
// {
//     int[,] matr = new int[rows, columns]; // строки столбцы
//     Random rnd = new Random();
//     // достать количество строк и столбцов - 0 отвечает за троки 1 за столбцы
//     for (int i = 0; i < rows; i++) // сначала в строчку rows = matr.GetLength(0)
//     {
//         for (int j = 0; j < columns; j++) // теперь в столбцы  columns = mart.GetLength(1)
//         {
//             matr[i, j] = rnd.Next(101); // если диапазон от ноля то 0 опускамем
//         }
//     }
//     return matr;
// }

// void PrintMatrix(int[,] matr)
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

// void SquareElements (int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matr [i,j] *= matr[i,j];
//             }
//         }
//     }
// }

// // вывод результата
// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] matr = CreateMatrix(rows, columns); // задаем создать матрицу на количетсво сторк и столбцов с терминала
// PrintMatrix(matr);
// Console.WriteLine("Результат: ");
// SquareElements(matr);
// PrintMatrix(matr);



// // task 2. главная диагональ в матрице - [0,0], [1,1], [2,2], [3,3]

// int[,] CreateMatrix(int rows, int columns) // двумерный массив [,] метод создания матрицы 
// {
//     int[,] matr = new int[rows, columns]; // строки столбцы
//     Random rnd = new Random();
//     // достать количество строк и столбцов - 0 отвечает за троки 1 за столбцы
//     for (int i = 0; i < rows; i++) // сначала в строчку rows = matr.GetLength(0)
//     {
//         for (int j = 0; j < columns; j++) // теперь в столбцы  columns = mart.GetLength(1)
//         {
//             matr[i, j] = rnd.Next(101); // если диапазон от ноля то 0 опускамем
//         }
//     }
//     return matr;
// }

// int GetMainDiagonalSum (int [,] matr)
// {
//     int sum = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//            if (i == j)
//            {
//              sum += matr [i, j];
//            }
//         }
//     }
//     return sum;
// }

// void PrintMatrix(int[,] matr)
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

// // вывод результата
// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] matr = CreateMatrix(rows, columns);
// PrintMatrix(matr);
// Console.WriteLine($"Результат: {GetMainDiagonalSum(matr)}");



// task 3

int[,] CreateMatrix(int rows, int columns) // двумерный массив [,] метод создания матрицы 
{
    int[,] matr = new int[rows, columns]; // строки столбцы
    Random rnd = new Random();
    // достать количество строк и столбцов - 0 отвечает за троки 1 за столбцы
    for (int i = 0; i < rows; i++) // сначала в строчку rows = matr.GetLength(0)
    {
        for (int j = 0; j < columns; j++) // теперь в столбцы  columns = mart.GetLength(1)
        {
            matr[i, j] = rnd.Next(101); // если диапазон от ноля то 0 опускамем
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // проход по строчкам двумерного массива
    {
        for (int j = 0; j < matr.GetLength(1); j++) // проход по столбцам двухмерного массива
        {
            Console.Write($"{matr[i, j]}\t"); // \t - 4 пробела между элементами 
        }
        Console.WriteLine(); // перенос на новую строку
    }
}
double[] GetArrWithMeans (int[,] matrix)
{
    double[] means = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++) // проход по строчкам двумерного массива
    {
        double currentSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) // проход по столбцам двухмерного массива
        {
             currentSum += matrix[i, j];
        }
        double currentMean = Math.Round(currentSum / matrix.GetLength(1),2);
        means[i] = currentMean;
    }
    return means;
}

// вывод результата
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] matr = CreateMatrix(rows, columns);
PrintMatrix(matr);
double[] res = GetArrWithMeans(matr); 
Console.WriteLine($"Массив: [{string.Join("; ", res)} ]");

// task 1.  Создать двумерный массив с размером 3 * 5 из целых чисел и вывести элементы на экран
    int [,] CreateMatrix (int rowCount, int columsCount)
    {
    int[,] matrix = new int[rowCount, columsCount]; // сначала строки потом столбцы
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // запрашиваем количество строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // запрашиваем по количеству столбцов
        {

            matrix[i, j] = rnd.Next (1, 11);
        }
    }
    return matrix;
}

void PrintMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // запрашиваем количество строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // запрашиваем по количеству столбцов
        {

            Console.Write($"{matrix[i, j]} "); // интерпаляция строк
        }
        Console.WriteLine();
    }
}

//  вывод результата
int[,] matrix = CreateMatrix(4, 5);
PrintMatrix(matrix);




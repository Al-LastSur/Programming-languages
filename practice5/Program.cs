//  двумерные массивы // ноль это четное число?
int[,] CreateMatrix (int rows, int columns) // двумерный массив [,] метод создания матрицы 
{
    int [,] matr = new int [rows, columns]; // строки столбцы
    Random rnd = new Random();
    // достать количество строк и столбцов - 0 отвечает за троки 1 за столбцы
    for (int i = 0; i <rows ; i++) // сначала в строчку rows = matr.GetLength(0)
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
            Console.Write($"{matr[i,j]}\t"); // \t - 4 пробела между элементами 
        }
        Console.WriteLine(); // перенос на новую строку
    }
}

// вывод результата
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] matr = CreateMatrix(rows,columns); // задаем создать матрицу на количетсво сторк и столбцов с терминала
PrintMatrix(matr);

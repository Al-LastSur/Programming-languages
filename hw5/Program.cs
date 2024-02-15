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
// int[] LinesSum(int[,] array)
// {
//       int res = 0;
//       int[] Narr = new int[array.GetLength(0)];
//       for (int i = 0; i < array.GetLength(0); i++)
//       {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {    
//             res = array[i,j] + res;
//             Narr[i] = res;
//         }
//         res = 0;
//       }

        
//     //     for (int i = 0; i < array.GetLength(0); i++)
//     // {  
        
//     // }
//     return Narr;
// }
// int MinIndex (int[] array)
// {
//     int min = array[0];
//     int minI = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array [i] < min)
//         {
//             min = array[i];
//             minI = i;
//         }
//     }
//     return minI;
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
// // Console.WriteLine($"Результат: {string.Join(; ), }");
// Console.WriteLine($"Массив  суммы строк: [{string.Join("; ", LinesSum(matr))} ]");
// int res = MinIndex(LinesSum(matr));
// Console.WriteLine($"Строка с наименьшим результатом:  {res}");


// task 2. 
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

//  обмен первой и последней строки
int [,] ChangeLines (int[,] array)
{


for (int i = 0; i < array.GetLength(1); i++)
      {
        ChangeIndexes(array, i);
      }
      return array;
}

int[,] ChangeIndexes (int[,] array, int i)
{
// int[] Narr = new int[array.GetLength(0)]; // хороший но не рабочий способ
    
//       for (int i = 0; i < array.GetLength(0); i++)
//       {
        
      
          int k = array.GetLength(0) -1; // сколько строк в массиве (определяем номер последней строки для проги)
          int temp = array [0, i];
          
          array [0, i] = array [k, i];

          array [k, i] =  temp;

   
    // }
      return array;
}

//  обмен элементами массива


// вывод результата
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matr = CreateMatrix(rows, columns);
PrintMatrix(matr);
// ChangeLines(matr);
Console.WriteLine ("Результат");
PrintMatrix(ChangeLines(matr));

// Console.WriteLine($"Результат: {string.Join(; ), }");
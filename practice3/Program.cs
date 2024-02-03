// // Task1.Set a program when it shows if there is an input number at the array
// int[] array = {11, 23, 44, 77, 66, 101, 154, 48, 47};
// Console.Write("Введите искомое значение: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int numberToFind = 44;
// bool isFound = false;
// for(int i = 0; i < arraly.Length; i++)
// {
//     if (numberToFind == array [i])
//     {
//         isFound = true;
//         break;
//     }
// }
// if (isFound)
// {
//     Console.WriteLine ("Да");
// }
// else
// {
//     Console.WriteLine ("Нет");
// }

// // Task 2. Set a program when it shows all the number of array multiplied by -1
// int[] array = {11, -23, 44, -77, 66, 101, -154, 0, -47};
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = -array[i]; // array[i] = array [i] + 40 == array [i] += 40; 
// }
// Console.WriteLine($"Массив: [ {string.Join("; ", array)}");

//  Task 3. The program provides the mulpiplication of two numbers in an array staying the fisrt and the last.

int[] array = { 2, 4, 3, 6, 3, 5, 7, 3 };
int[] result = new int[array.Length / 2];
for (int i = 0, j = array.Length - 1; i < result.Length; i++, j--)
{
    result[i] = array[i] * array[j];
}
Console.WriteLine($"Массив: [ {string.Join("; ", result)} ]");
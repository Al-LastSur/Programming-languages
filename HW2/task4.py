# Console.Write("Введите натуральное число: ");
# int number = Convert.ToInt32(Console.ReadLine());
number = 1000000000
razruad = 1000000000
if (number <= Math.Pow(2,31)):
    while (number >= razruad):
        if (number % 10 != 0):
            result = number / razruad
            # Console.Write($"{result}, ");
            razruad = razruad / 10
        else:
        # Console.Write("0, ");
            razruad = razruad /10
    else:
        razruad = razruad / 10
else:
    Console.WriteLine("Вы вышли за пределы допустимых значений");



int [] numbers = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
int i = 0;
int count = 0;
int result = 0;
int maxRange = 90;
int minRange = 10;
for (i = 0; i < numbers.Length; i++)
{
count++;
}
if (numbers[i] <= maxRange && numbers[i] >= minRange)
{
    result = result + 1;
    i++; 
}
i++;

Console.WriteLine (result);
//  Solve task (a*b)/(c+d) with help of a function
double CalculateFormula(int a, int b, int c, int d)
{
    int nomenator = a * b;
    double denomenator = c + d;
    double result = nomenator / denomenator;
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);

Console.WriteLine(result); 
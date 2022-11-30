// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
int [] CreateArray (int M)
{
    int [] newArray = new int [M];
    Console.WriteLine($"Input {M} numbers one by one: ");

    for (int i = 0; i < M; i++)
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    return newArray;
}

void Positive (int[] Array)
{
    int sumPos = 0;

    for (int i = 0; i < Array.Length; i ++)
        if (Array[i] > 0)
            sumPos++;

    string word = String.Empty;
    if (sumPos == 1)
        word = "number";
    else word = "numbers";
    Console.WriteLine ($"You entered {sumPos} {word} greater than 0");
}

Console.WriteLine ("Input size of array");
int M = Convert.ToInt32(Console.ReadLine());

int []array =CreateArray (M);
Positive (array);
*/



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double XCoord(double K1, double K2, double B1, double B2)
{
    double X = (B2 - B1) / (K1 - K2);
    return X;
}

double YCoord(double K1, double K2, double B1, double B2)
{
     double Y = K1 * (B2 - B1) / (K1 - K2) + B1;
    return Y;
}

Console.WriteLine();
Console.WriteLine("Enter line equation сoefficients");
Console.WriteLine();

Console.WriteLine("First line: ");
Console.Write("b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Second line: ");
Console.Write("b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = Math.Round (XCoord(k1, k2, b1, b2), 3);
double y = Math.Round (YCoord(k1, k2, b1, b2), 3);

Console.WriteLine();
Console.WriteLine($"Coordinates of the point of intersection of lines: ({x}, {y})");
Console.WriteLine();



// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*
double[,] Create2Array(int row, int column, int minVal, int maxVal)
{
    double[,] createArray = new double[row,column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            createArray[i, j] = Math.Round (new Random().Next(minVal,maxVal) + new Random().NextDouble(), 1);
        }
    }
    return createArray;
}

void Show2Array(double [,] array)
{
    for (int i = 0;  i < array.GetLength(0); i ++)
        {
            for (int j = 0; j < array.GetLength(1); j ++)
            {
                Console.Write(array[i,j]+ " ");
            }
            Console.WriteLine();
        }
    Console.WriteLine();
}

Console.WriteLine("Input count of rows m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns n: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double [,] newArray = Create2Array (rows, columns, min, max);
Show2Array (newArray);
*/



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

/*
int[,] Create2Array(int row, int column, int minVal, int maxVal)
{
    int[,] createArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            createArray[i, j] = new Random().Next(minVal, maxVal);
        }
    }
    return createArray;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowElement(int[,] array, int position)
{
    int elRow = position / 10;
    int elColumn = position % 10;

    if (elRow >= array.GetLength(0) || elColumn >= array.GetLength(1))
        Console.WriteLine("There is no element with this number");
    else
        Console.WriteLine($"This element is {array[elRow, elColumn]}");
}

int[,] newArray = Create2Array(5, 6, -10, 10);
Show2Array(newArray);

Console.WriteLine("Input position of element (two digits): ");
int element = Convert.ToInt32(Console.ReadLine());

ShowElement(newArray, element);
*/



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] Create2Array(int row, int column, int minVal, int maxVal)
{
    int[,] createArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            createArray[i, j] = new Random().Next(minVal, maxVal);
        }
    }
    return createArray;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double []ColumnAverage(int[,] array)
{
    int size =  array.GetLength(1);
    double [] columnAverage = new double [size];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sumColumn = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumColumn += array[i, j];
        }
        double average = Math.Round ((sumColumn / array.GetLength(0)), 2);
        columnAverage[j] = average;
        Console.Write (columnAverage[j] + "  ");
    }
    return columnAverage;
}

int[,] newArray = Create2Array(5, 6, -10, 10);
Show2Array(newArray);

Console.WriteLine();
Console.WriteLine("Averages: ");
ColumnAverage(newArray);
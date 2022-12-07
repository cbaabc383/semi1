// //Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
int [,] Create2Array(int row, int column, int minVal, int maxVal)
{
    int [,] created2Array = new int [row, column];

    for (int i = 0;  i < row; i ++)
        for (int j = 0; j < column; j ++)
            created2Array [i, j] = new Random().Next(minVal, maxVal + 1);
    return created2Array;
}

void Show2Array(int [,] array)
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

Console.WriteLine("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] newArray = Create2Array (rows, columns, min, max);
Show2Array (newArray);
*/



// Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: 
//Aₘₙ = m+n. Выведите полученный массив на экран.

/*
int [,] Create2Array(int row, int column)
{
    int [,] created2Array = new int [row, column];

    for (int i = 0;  i < row; i ++)
        for (int j = 0; j < column; j ++)
            created2Array [i,j] = i + j;
    return created2Array;
}

void Show2Array(int [,] array)
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

Console.WriteLine("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] newArray = Create2Array (rows, columns);
Show2Array (newArray);
*/


//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.
/*
int [,] Create2Array(int row, int column, int minVal, int maxVal)
{
    int [,] created2Array = new int [row, column];

    for (int i = 0;  i < row; i ++)
        for (int j = 0; j < column; j ++)
            created2Array [i, j] = new Random().Next(minVal, maxVal + 1);
    return created2Array;
}

void Show2Array(int [,] array)
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

Console.WriteLine("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] newArray = Create2Array (rows, columns, min, max);
Show2Array (newArray);
*/



// Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: 
//Aₘₙ = m+n. Выведите полученный массив на экран.


int [,] Create2Array(int row, int column)
{
    int [,] created2Array = new int [row, column];

    for (int i = 0;  i < row; i ++)
        for (int j = 0; j < column; j ++)
            created2Array [i,j] = i + j;
    return created2Array;
}

void Show2Array(int [,] array)
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

int[,] EverNumbers (int [,] array)
{
    for (int i = 0;  i < array.GetLength(0); i ++)
        {
            for (int j = 0; j < array.GetLength(1); j ++)
            {
                if (i % 2 == 0 && j % 2 == 0)
                    array [i, j] = array[i, j] * array[i, j];
            }
        }
    return array;
}

int[,] created2Array = Create2Array (5,6);
Show2Array(created2Array);
EverNumbers (created2Array);
Show2Array(created2Array);




//Найти сумму элементов главной диагонали

/*
int[,] Create2Array(int row, int column, int minVal, int maxVal)
{
    int[,] created2Array = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            created2Array[i, j] = new Random().Next(minVal, maxVal + 1);
    return created2Array;
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

int SumNumber(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (i == j)
                sum = sum + array[i, j];
    return sum;
}

int[,] newArray = Create2Array (3, 4,-5,10);
Show2Array(newArray);
Console.WriteLine(SumNumber(newArray));
*/
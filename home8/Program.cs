// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
/*
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

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
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] RowBackward (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int max = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, max])
                    max = k;
            }
            int temp = array[i, j];
            array[i, j] = array[i, max];
            array[i, max] = temp;
        }
    }
    return array;
}


int[,] newArray = Create2Array(3, 5, -10, 10);
Show2Array(newArray);

int[,] backward = RowBackward (newArray);
Show2Array(backward);
*/




// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
/*
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

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
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int  SumRow(int[,] array, int row)
{
    int sumRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumRow += array[row, j];
    }
    return sumRow;
}

int MinRow(int[,] array)
{
    int minVal = SumRow(array, 0);
    int minRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (SumRow (array, i) < minVal)
            minRow = i;
    }
    return minRow;
}

int[,] newArray = Create2Array(5, 6, 0, 10);
Show2Array(newArray);
Console.WriteLine($"Minimal row is: {MinRow(newArray)}");
*/



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
/*
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


int[,] Spiral(int row, int column)
{
    int[,] array = new int[4, 4];
    int start = 1;

    int i = 0;
    for (int j = 0; j <= 3; j++)
    {
        array[i, j] = start;
        start++;
    }

    int k = 3;
    for (int l = 1; l <= 3; l++)
    {
        array[l, k] = start;
        start++;
    }

    int m = 3;
    for (int n = 2; n >= 0; n--)
    {
        array[m, n] = start;
        start++;
    }

    int p = 0;
    for (int o = 2; o >= 1; o--)
    {
        array[o, p] = start;
        start++;
    }

    int q = 1;
    for (int r = 1; r <= 2; r++)
    {
        array[q, r] = start;
        start++;
    }

    int t = 2;
    for (int s = 2; s <= 2; s++)
    {
        array[s, t] = start;
        start++;
    }
    
    int u = 2;
    for (int v = 1; v >= 1; v--)
    {
        array[u, v] = start;
        start++;
    }

    return array;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
                Console.Write("0");
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] newArray = Spiral(4, 4);
Show2Array(newArray);

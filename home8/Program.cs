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


int[,] newArray = Create2Array(3, 5, 0, 10);
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





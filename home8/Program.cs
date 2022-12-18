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

/*
int[,] Spiral(int row, int column)
{
    int[,] array = new int[4,4];
    int start = 1;

    int i = 0;
    int j = 0;
    
    for (j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = start;
        start++;
    }

    j = array.GetLength(1) - 1;
    for (i = 1; i < array.GetLength(0); i++)
    {
        array[i, j] = start;
        start++;
    }

    i = array.GetLength(0) - 1;
    for (j = array.GetLength(1) - 2; j >= 0; j--)
    {
        array[i, j] = start;
        start++;
    }

    j = 0;
    for (i = array.GetLength(0) - 2; i >= 1; i--)
    {
        array[i, j] = start;
        start++;
    }


    i = 1;
    j = 1;
    for (j = 1; j < array.GetLength(1) - 1; j++)
    {
        array[i, j] = start;
        start++;
    }

    j = array.GetLength(1) - 2;
    for (i = 2; i < array.GetLength(0) - 1; i++)
    {
        array[i, j] = start;
        start++;
    }

    i = array.GetLength(0) - 2;
    for (j = array.GetLength(1) - 3; j >= 1; j--)
    {
        array[i, j] = start;
        start++;
    }

    j = 1;
    for (i = array.GetLength(0) - 3; i >= 2; i--)
    {
        array[i, j] = start;
        start++;
    }


    i = 2;
    j = 2;
    for (j = 2; j < array.GetLength(1) - 2; j++)
    {
        array[i, j] = start;
        start++;
    }

    j = array.GetLength(1) - 3;
    for (i = 3; i < array.GetLength(0) - 2; i++)
    {
        array[i, j] = start;
        start++;
    }

    i = array.GetLength(0) - 3;
    for (j = array.GetLength(1) - 4; j >= 2; j--)
    {
        array[i, j] = start;
        start++;
    }
   
    j = 2;    
    for (i = array.GetLength(0) - 4; i >= 3; i--)
    {
        array[i, j] = start;
        start++;
    }


    i = 3;
    j = 3;
    for (j = 3; j < array.GetLength(1) - 3; j++)
    {
        array[i, j] = start;
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
*/



/*Задача 58(дополнительно): Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] MultiArray(int row, int column, int[,] array1, int[,] array2)
{
    int[,] multiArray = new int[row, column];
     for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            multiArray[i, j] = (array1[i, 0] * array2[0, j]) + (array1[i, 1] * array2[1, j]);
        }
    }
    return multiArray;
}


int[,] firstArray = Create2Array(2,2,0,10);
Show2Array(firstArray);

int[,] secondArray = Create2Array(2,2,0,10);
Show2Array(secondArray);

int[,] newArray = MultiArray(2,2,firstArray,secondArray);
Show2Array(newArray);
*/


/*
Задача 60(дополнительно): ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] Create3dArray(int row, int column, int layer, int minVal, int maxVal)
{
    int[,,] createArray = new int[row, column, layer];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < layer; k++)
            {
                createArray[i, j, k] = new Random().Next(minVal, maxVal);
            }    
        }
    }
    return createArray;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

int[,,] newArray = Create3dArray(2, 2, 2, 10, 100);
Show3dArray(newArray);
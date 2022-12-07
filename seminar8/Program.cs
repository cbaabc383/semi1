// // Задайте двумерный массив. Напишите программу, которая поменяет 
// местами две любые строки массива.

/*
int[,] Create2dArray(int rows, int columns, int minVal, int maxVal)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minVal, maxVal + 1);
    return newArray;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] ChangeArrayRows (int[,] array1, int row1, int row2)
{
    if (row1 >= 0 && row1 < array1.GetLength(0) && row2 >= 0 && row2 < array1.GetLength(0) && row1 != row2)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                int temp = array1[row1, j];
                array1[row1, j] =array1 [row2, j];
                array1 [row2, j] = temp;
            }
 
    }
    else Console.WriteLine("Incorrect input");
    return array1;
}

Console.WriteLine("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());



int [,] newArray = Create2dArray (rows, columns, min, max);
Show2Array (newArray);
Show2Array (ChangeArrayRows(newArray, userRow1, userRow2));
*/

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// 1 2 3 4    1 3 7 4 
// 3 4 5 6    2 4 8 5   
// 7 8 9 1    3 5 9 6 
// 4 5 6 7    4 6 1 7
/*
int[,] Create2dArray(int rows, int columns, int minVal, int maxVal)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minVal, maxVal + 1);
    return newArray;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeArray (int [,] array2)
{ 
    if (array2.GetLength(0) <= 0 ||array2.GetLength(1) <=0)
    {
        Console.WriteLine("It shoud be square matrix");
    }
    else
    {
        int[,] array3 = new int[array2.GetLength(1), array2.GetLength(0)];
        for (int i = 0; i < array2.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                array3[j, i] = array2 [i, j];
            }
        }
        Show2Array(array3);
    }
    
}

Console.WriteLine("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] newMatrix = Create2dArray(rows, columns, min, max);
Show2Array(newMatrix);
ChangeArray(newMatrix);
*/




// Задайте двумерный массив из целых чисел. Напишите программу, 
// которая обнулит строку и столбец, 
// на пересечении которых расположен первый наименьший элемент массива.

int[,] Create2dArray(int rows, int columns, int minVal, int maxVal)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minVal, maxVal + 1);
    return newArray;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] GetMinIndex(int[,] inArray)
{
    int iMin = 0;
    int jMin = 0;

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] < inArray[iMin, jMin])
            {
                iMin = i;
                jMin = j;
            }
        }
    }
    return new[] { iMin, jMin };
}

void GetZero(int[,] arrayStart, int[] minInd)
{
    for (int i = 0; i < arrayStart.GetLength(0); i++)
    {
        arrayStart[i, minInd[1]] = 0;
        for (int j = 0; j < arrayStart.GetLength(1); j++)
        {
            arrayStart[minInd[0], j] = 0;
        }
    }
    Show2Array(arrayStart);
}

Console.WriteLine("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,]firstArray = Create2dArray(rows, columns, min, max);
Show2Array(firstArray);
int[] minIndexArray = GetMinIndex(firstArray);
GetZero (firstArray, minIndexArray);

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


/*
int [] CreateRandomArray (int size)
{
    int [] newArray = new int [size];

    for (int i = 0; i < size; i++)
    {
        newArray[i]=new Random().Next(100, 1000);
            }
            return newArray;
}

void ShowArray (int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write (Array[i] + " ");
            }
Console.WriteLine ();
}

void Positive (int[] Array)
{
    int Pos = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        int half = Array [i] / 2;
        if (half * 2 == Array[i])
            Pos++;
    }
    Console.WriteLine ($"Summ of positive numbers in array is: {Pos}");
}

Console.WriteLine ("Input size of array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int []createdArray = CreateRandomArray (sizeArray);

ShowArray (createdArray);

Positive (createdArray);
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


/*
int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
            return newArray;
}

void ShowArray (int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write (Array[i] + " ");
            }
Console.WriteLine ();
}

void SumOdd (int[] Array)
{
    int sumOdd = 0;

    for (int i = 1; i < Array.Length; i = i + 2)
        sumOdd = sumOdd + Array [i];

    Console.WriteLine ($"Summ of numbers in odd positions is {sumOdd}");
}

Console.WriteLine ("Input size of array");
int array_size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input min possible val of array");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input max possible val of array");
int maxValue = Convert.ToInt32(Console.ReadLine());

int []array =CreateRandomArray (array_size, minValue, maxValue);
ShowArray (array);

SumOdd (array);
*/




// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double [] CreateRandomArray (int size, int minValue, int maxValue)
{
    double [] newArray = new double [size];

    for (int i = 0; i < size; i++)
    {
        int abc = new Random().Next(minValue, maxValue);
        newArray[i] = Math.Round (new Random().NextDouble() + abc, 3);
    }
    return newArray;
}

void ShowArray (double[] Array)
{
    for (int i = 0; i < Array.Length; i++)
        Console.Write (Array[i] + " ");
    
Console.WriteLine ();
}

double MaxArray (double[] Array)
{
    double max = Array[0];
    for (int i = 0; i < Array.Length; i ++)
        if (Array[i] > max)
            max = Array[i];
    return max;
}

double MinArray (double[] Array)
{
    double min = Array[0];
    for (int i = 0; i < Array.Length; i ++)
        if (Array[i] < min)
            min = Array[i];
    return min;
}

Console.WriteLine ("Input size of array");
int array_size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input min possible val of array");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input max possible val of array");
int maxValue = Convert.ToInt32(Console.ReadLine());

double []array =CreateRandomArray (array_size, minValue, maxValue);
ShowArray (array);

Console.WriteLine ($"Max = {Math.Round (MaxArray(array), 3)}");
Console.WriteLine ($"Min = {Math.Round (MinArray (array), 3)}");

Console.WriteLine ($"Max - Min = {Math.Round (MaxArray(array) - MinArray (array), 3)}");

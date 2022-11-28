// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int [] CreateRandomArray (int size, int minValue, int maxValue)
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
/*
int FindSumPos (int[] array)
{
    int sumPos = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            sumPos += array [i];
    return sumPos;
        
}
int FindSumNeg (int[] array)
{
    int SumNeg = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0)
            SumNeg += array [i];
    return SumNeg;
}
int size_array = 12;
int minValue = -9;
int maxValue = 9;

int []createdArray = CreateRandomArray (size_array, minValue, maxValue);
*/
ShowArray (createdArray);

/*
Console.WriteLine ($"Sum of positive elements is {FindSumPos(createdArray)}");
int resultNeg = FindSumNeg (createdArray);
Console.WriteLine ($"Sum of negative elements is {FindSumNeg(createdArray)}");
*/

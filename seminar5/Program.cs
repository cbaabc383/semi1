// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.


int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];

    for (int i = 0; i < size; i++)
    {
        newArray[i]=new Random().Next(minValue, maxValue+1);
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
ShowArray (createdArray);
Console.WriteLine ($"Sum of positive elements is {FindSumPos(createdArray)}");
int resultNeg = FindSumNeg (createdArray);
Console.WriteLine ($"Sum of negative elements is {FindSumNeg(createdArray)}");


//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21
/*
int [] CreateRandomArray (int size, int minValue, intMaxValue)
{
    int [] newArray = new int [size];

    for (int i = 0; i < size; i++)
    {
        newArray[i]=new Random().Next(minValue, maxValue+1);
            }
    return newArray;
}

void ShowArray (int[] Array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write (Array[i] + " ");
        Console.WriteLine ();
    }
}

int [] FindMultiPar (int []  arrayCreated, int size2)
{
    int size2;
    if (arrayCreated.Length % 2 == 0)
        size2 = arrayCreated.Length  / 2;
    else
        size2 = (arrayCreated.Length  +1) / 2;
    int [] arrayMulti = new int [size2];
    for (int i = 0; i < arrayCreated.Length / 2; i++)
    {
        arrayMulti [i] = arrayCreated[i] * arrayCreated[arrayCreated.Length - 1 - i];
    }
    if (int = arrayCreated.Length-1-i)
    {
        arrayMulti[size2-1] = arrayCreated[i];
    }
    if (arrayCreated.Length %2 = 0)
        arrayMulti [size2-1] = arrayCreated[arrayCreated.Length-1-i];
    return arrayMulti;
}

Console.WriteLine ("input size of array");
int array_size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input min possible val of array");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input max possible val of array");
int maxValue = Convert.ToInt32(Console.ReadLine());

int []array1 =CreateRandomArray (array_size, minValue, maxValue);
ShowArray (array1);
int []array2 = FindMultiPar(array1);
ShowArray (array2);
*/

//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

/*
int []createdArray = CreateRandomArray (size_array, minValue, maxValue);
ShowArray (createdArray);
Console.WriteLine ($"Sum of positive elements is {FindSumPos(createdArray)}"");
int resultNeg = FindSumNeg (createdArray);
Console.WriteLine ($"Sum of negative elements is {FindSumNeg(createdArray)}"");
*/

//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21
/*
int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];

    for (int i = 0; i < size; i++)
    {
        newArray[i]=new Random().Next(minValue, maxValue+1);
    }
    return newArray;
 }

 void ShowArray (int[] Array)
 {
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write (Array[i] + " ");
        Console.WriteLine ();
    }
 }
 int Count1099 (int[]array)

{int count = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i] > 9 && array[i] < 100)
        count ++;
    
return count;
}

 int size_array = 123;
 Console.WriteLine ("input size of array");
int array_size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input min possible val of array");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input max possible val of array");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] arrayCreated = CreateRandomArray (size_array, minValue, maxValue);
ShowArray(arrayCreated);

int res = Count1099(arrayCreated);
Console.WriteLine ($"Count of elements between 10 and 99 is {res}");

*/

/*
 newArray[i]=new Random().Next(minValue, maxValue+1) + Random().NextDouble();
 Math.Round (newArray[i], 3);
 */

 //Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


/*
void Funkt (int x, int y)
{
if (x >0 && y >0)
{
    Console.WriteLine ("This point on 1st quater");
}
else if (x < 0 && y >0)
{
    Console.WriteLine ("This point on 2nd quater");
}
else if (x < 0 && y >0)
{
    Console.WriteLine ("This point on 3d quater");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine ("This point on 4th quater");
}
}
Console.WriteLine ("Input your X number:");
int xCoord = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Input your Y number:");
int yCoord = Convert.ToInt32 (Console.ReadLine());

Funkt (xCoord, yCoord);
*/


/*Напишите программу, которая по заданному номеру 
четверти, показывает диапазон возможных координат 
точек в этой четверти (x и y).
*/



void PossibleValue (int n)
{
if (n == 1)
    Console.WriteLine ("1st quater x > 0, y > 0");
else if (n == 2)
    Console.WriteLine ("2nd quater x < 0, y > 0");
else if (n == 3)
    Console.WriteLine ("3rd quater x > 0, y > 0");
else if (n == 4)
    Console.WriteLine ("4th quater x , 0, y < 0");
}

Console.WriteLine ("Input number of quater:");
int numQuater = Convert.ToInt32 (Console.ReadLine());

if (numQuater >= 1 && numQuater <= 4)
    PossibleValue (numQuater);
else 
    Console.WriteLine ("It is not number of quater");



/* Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между 
ними в 2D пространстве.
*/


//Math.Sqrt (num) 
// doule тип метода с плавающей точкой (не целые числа)

/*
double LongLine (int x1, int y1, int x2, int y2)
{
    int x = x2-x1;
    int y=y2-y1;
    double lenghtAB = Math.Round (Math.Sqrt (x*x + y*y), 3);
    return lenghtAB;
}
Console.WriteLine ("Input X coordinat of A:");
int xA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input Y coordinat of A:");
int yA = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Input X coordinat of B:");
int xB = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input Y coordinat of B:");
int yB = Convert.ToInt32 (Console.ReadLine());

double dist = LongLine (xA, yA, xB, yB);
Console.WriteLine ("Distance AB is: {dist: f3}");
*/


/*
Напишите программу, которая принимает на вход число (N) и выдаёт
 таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

void Qurd (int num)
{
    int current = 1;
    while (current <= num)
    {
        int res = current * current;
        Console.Write ($"{res}, ");
        current ++;
    }
Console.WriteLine ($"\b\b.");
}
Console.WriteLine ("Input number:");
int number = Convert.ToInt32 (Console.ReadLine());

if (number >=1)
{

    Console.Write($"{number} -> ");
    Qurd (number);
}
else Console.WriteLine ("Impossible number");


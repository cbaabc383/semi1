// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


void power (int A, int B)
{
    int result = A;
    for (int i = 1; i < B; i++)
    {
        result *= A;
    }
    Console.WriteLine ($"{A} to the {B} power is {result}");
}

Console.Write("Input number:");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Input power:");
int B = Convert.ToInt32(Console.ReadLine());

if (B < 0)
    Console.WriteLine("Input a positive power!");
else if (B == 0)
    Console.WriteLine ($"{A} to the 0 power is 1");
else 
    power (A, B);




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


void numSum (int number)
{   
    int res = 0;
    int temp = number;

    if (number < 0)
        number = number * (-1);
        
    while (number > 0)
        {
        int sum = number % 10;
        res = res + sum;
        number = number / 10;      
        }

    Console.WriteLine ($"Sum of numbers in {temp} is {res}");
}

Console.WriteLine ("Input number:");
int userNum = Convert.ToInt32(Console.ReadLine());

numSum (userNum);




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int [] CreatNewArray (int min, int max)
{
    int [] array = new int [8];
    for (int i = 0; i < 8; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void ShowArray (int [] array)
{
     for (int i = 0; i < 8; i++)
    {
        Console.Write (array[i] + " ");
    }
}

Console.Write ("Itput min value of elements: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write ("Itput max value of elements: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

ShowArray (CreatNewArray(minValue, maxValue));

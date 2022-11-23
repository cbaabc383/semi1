//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

/*
int CountOfDigits (int number)
{
    int index = 0;
    int current = 1;
    if (number >= Math.Pow(10, index));
    while (number >= 10)
    {
        current++;
        number = number/10;
    }
    return current;
}
Console.WriteLine ("Input number:");
int userNum = Convert.ToInt32(Console.ReadLine());

int count_digit;
int userNum1 = (-1) * userNum;
if (userNum >0)
    count_digit = CountOfDigits(userNum);
else 
    count_digit = CountOfDigits (userNum1);

Console.WriteLine ($"Enterer number {userNum} -> {count_digit}");
*/

//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

/*
void factorial (int n)
{
    int multi = 1; //4 -> 24 multi > n ->
    for (int cur = 1; cur <= n; cur++)
    {
        multi *= cur;
    }
Console.WriteLine("Input number:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    while (number < 0)
    {
        Console.WriteLine("Pls, input POSITIVE int number");
        number = Convert.ToInt32(Console.ReadLine());
    }
}

factorial (number);
*/
//yfgишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

/*
int [] CreatNewArray (int size)
{
    int [] array = new int [size]; // int(1) тип данных массива [] array  - имя массива newint[размер массива]
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(0, 2);
    return array;
}

void ShowArray (int [] array)
{
     for (int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
}
Console.Write ("Itput count of elements:");
int countOfElements = Convert.ToInt32(Console.ReadLine());
int [] array1 = CreatNewArray (countOfElements);
ShowArray (array1);

ShowArray (CreatNewArray(countOfElements));
*/
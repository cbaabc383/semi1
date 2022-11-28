/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
Console.WriteLine ("Enter two numbers:");
int num1 = Convert.ToInt32 (Console.ReadLine());
int num2 = Convert.ToInt32 (Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine ($"Number {num1} is greater than {num2}");
    }
else
{
    Console.WriteLine ($"Number {num2} is greater than {num1}");
}
*/
/*Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/


void Funkt(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("This point on 1st quater");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("This point on 2nd quater");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("This point on 3d quater");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("This point on 4th quater");
    }
}
Console.WriteLine("Input your X number:");
int xCoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input your Y number:");
int yCoord = Convert.ToInt32(Console.ReadLine());

Funkt(xCoord, yCoord);



/*Напишите программу, которая по заданному номеру 
четверти, показывает диапазон возможных координат 
точек в этой четверти (x и y).
*/


/*
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
*/


/* Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между 
ними в 2D пространстве.
*/


//Math.Sqrt (num) 
// doule тип метода с плавающей точкой (не целые числа)


double LongLine(int x1, int y1, int x2, int y2)
{
    int x = x2 - x1;
    int y = y2 - y1;
    double lenghtAB = Math.Round(Math.Sqrt(x * x + y * y), 3);
    return lenghtAB;
}
Console.WriteLine("Input X coordinat of A:");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinat of A:");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input X coordinat of B:");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinat of B:");
int yB = Convert.ToInt32(Console.ReadLine());

double dist = LongLine(xA, yA, xB, yB);
Console.WriteLine($"Distance AB is: {dist :f3}");



/*
Напишите программу, которая принимает на вход число (N) и выдаёт
 таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

void Qurd(int num)
{
    int current = 1;
    while (current <= num)
    {
        int res = current * current;
        Console.Write($"{res}, ");
        current++;
    }
    Console.WriteLine($"\b\b.");
}
Console.WriteLine("Input number:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1)
{

    Console.Write($"{number} -> ");
    Qurd(number);
}
else Console.WriteLine("Impossible number");


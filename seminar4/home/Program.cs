//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

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
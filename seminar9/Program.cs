// Задайте значение N, напишите программу, которая выведет все натуральные
// числа от 1 до N 
/*
void ShowNumbers(int n)
{
    if (n > 1) ShowNumbers(n - 1);
    Console.Write(n + " ");
}
ShowNumbers(3);

void ShowNumbers(int n)
{
    Console.Write(n + " ");
    if (n > 1) ShowNumbers(n - 1);
}
ShowNumbers(3);
*/


// Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.
/*
int SumDigit(int num)
{
    if (num < 0) num *= (-1);
    if (num > 0) return SumDigit(num / 10) + num % 10;
    else return 0;
}

Console.WriteLine("Input num:  ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumDigit(number);
Console.WriteLine(result);
*/

// Задайте значения M и N. Напишите программу, которая выводит все
// натуральные числа в промежутке от M до N.
// N < M, N = M, M < N.

void ShowNumbersMN(int n, int m)
{
    
    if (Math.Max(n,m) != Math.Min(n, m)) ShowNumbersMN(Math.Max(n,m)-1, Math.Min(n, m));
    Console.Write(Math.Max(n,m) + " ");
}
ShowNumbersMN(5,8);

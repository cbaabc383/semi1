﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

/*
void ShowNatural(int n)
{
    Console.Write(n + " ");
    if (n > 1) ShowNatural(n - 1);
    if (n < 1) ShowNatural(n + 1);
}
ShowNatural(1);
*/



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
/*
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
int SumNatural(int n, int m)
{
    if (m >= n) return SumNatural(n + 1, m) + n;
    return 0;
}
int res = SumNatural(4,8);
Console.WriteLine(res);
*/



// Задача 68: дополнительно Напишите программу вычисления
// функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
/*
int A(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 1 && n ==0) return A(m - 1, 1);
    else return A(m - 1, A(m, n - 1));
}
int res = A(1,1);
Console.WriteLine(res);
*/



//Задача: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную


string res = String.Empty;
string Convert10to2(int num)
{  
  int modulo = num % 2;
  if (num > 0) res = Convert10to2(num/2) +  modulo.ToString();
  return res;
}

Console.Write("Input a decimal number: ");
int dec = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{Convert10to2(dec)} in binary");

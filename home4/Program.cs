/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine ("Enter your number:");
int N = Convert.ToInt32 (Console.ReadLine());
int num = 2;
while (num <= N)
{
    Console.Write ($"{num} , ");
    num = num + 2;
}
/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine ("Enter your number:");
int num = Convert.ToInt32 (Console.ReadLine());
int sign = num / 2;
if (num == sign * 2)
{
    Console.WriteLine ($"{num} is even number");
    }
else
{
   Console.WriteLine ($"{num} is odd number"); 
}
/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int second (int num)
{
    int dec = (num % 100 - num % 10) / 10;
    return dec;
}

Console.Write ("Input your 3digit number: ");

int UserNum = Convert.ToInt32 (Console.ReadLine());
Console.Write ($"The second digit is {second(UserNum)}");



/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

/*
int second (int num)
{
    int dec = (num % 100 - num % 10) / 10;
    return dec;
}

Console.Write ("Input your 3-digit number: ");
int UserNum = Convert.ToInt32 (Console.ReadLine());

Console.Write ($"The second digit is {second(UserNum)}");
*/



/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int third (int num)
{
    int three = (num / 100) % 10;
    return three;
}
Console.Write ("Input your number: ");
int UserNum = Convert.ToInt32 (Console.ReadLine());
if (UserNum > 99)
    Console.Write ($"The third digit of your number is {third (UserNum)}");
else
    Console.Write ("Your number doesn't have third digit");




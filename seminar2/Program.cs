/*напишите программу, которая получает на вход двухзначное число, 
и показывает наибольшую цифру числа
 */

/*
int Digits (int num) //объявление метода Digit, который получает в качестве аргумента целое число и возвращает тоже целое
{
    int ed = num % 10; //поиск едениц (остаток от деления на 10) 
    int dec = num / 10;

    int result;                 //
    if (ed > dec) {             // if (ed > dec) {
        result = ed;            // return ed;
    }                           // }
    else result = dec;          // else return dec;

    return result;              //
}

Console.Write ("Input your 2digit number:");
int UserNum = Convert.ToInt32 (Console.ReadLine());

int res = Digits (UserNum);

Console.Write ($"The biggest digit is {res}");
*/


/*
int Digits (int num) 
{
    int ed = num % 10; 
    int dec = num / 10;

     if (ed > dec) {
     return ed;
    }                         
    else return dec;
    }

Console.Write ("Input your 2digit number:");
int UserNum = Convert.ToInt32 (Console.ReadLine());

int res = Digits (UserNum);

Console.Write ($"The biggest digit is {res}");
*/


/*напишите программу, которая получает на вход СЛУЧАЙНОЕ двухзначное число, 
и показывает наибольшую цифру числа
 */

/*
 int Digits (int num) //объявление метода Digit, который получает в качестве аргумента целое число и возвращает тоже целое
{
    int ed = num % 10; //поиск едениц (остаток от деления на 10) 
    int dec = num / 10;

    int result;                 //
    if (ed > dec) {             // if (ed > dec) {
        result = ed;            // return ed;
    }                           // }
    else result = dec;          // else return dec;

    return result;              //
}

int randomNum = new Random().Next (10, 100);
int res = Digits (randomNum);

Console.Write ($"The biggest digit of {randomNum} is {res}");
*/

/*
int Digits () 
{
    int randomNum = new Random().Next (10, 100);
    Console.WriteLine ($"Your number is {randomNum}");
    
    int ed = randomNum % 10; //поиск едениц (остаток от деления на 10) 
    int dec = randomNum / 10;

    int result;                 //
    if (ed > dec) {             // if (ed > dec) {
        result = ed;            // return ed;
    }                           // }
    else result = dec;          // else return dec;

    return result;              //
}

Console.Write ($"The biggest digit is {Digits()}");
*/


//напишите задачу, которая получает на вход число и проверяет, кратно ли оно одновременно двум другим



void Cratnost (int num, int a, int b)
{
    if (num % a == 0 && num % b == 0)
        Console.WriteLine ($"Your number {num} multiple of {a} and {b}");

    else Console.WriteLine ($"Your number {num} Not multiple of {a} and {b}");
}

Console.WriteLine ("Enter you number:");
int userName = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Enter you denominator1:");
int den1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Enter you denominator2:");
int den2 = Convert.ToInt32(Console.ReadLine());

Cratnost (userName, den1, den2);



//напишите программу, которая выводить случайное трехзначное число и удаляет вторую цифру этого числа
// 486 -> 46, 789 -> 79

/*
int DeliteDec ()
{
    int randomNum = new Random().Next (100,1000);
    Console.WriteLine ($"Your number is {randomNum}");

    int futDec = randomNum / 100;
    int futEd = randomNum % 10;

    int futNum = futDec * 10 + futEd;
    return futNum;
}

Console.WriteLine ($"Your new number is {DeliteDec()}");
*/
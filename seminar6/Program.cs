//Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

/*
int[] CreateNewArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowNewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int []ReverseArray(int[] array)
{
    int k = array.Length;
    for (int i = 0; i < k / 2; i++)
    {
        int temp = array[i];
        array[i] = array[k - 1 - i];
        array[k - 1 - i] = temp;
    }
    return array;
}

Console.WriteLine("Input size of array: ");
int countOfElements = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min of array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max of array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[]newArray = CreateNewArray(countOfElements, minValue, maxValue);
ShowNewArray(newArray);
int[]reverseArray = ReverseArray(newArray);
ShowNewArray(reverseArray);

*/













































































// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b (пользователь).

// F(i) = F(i-1)+F(i-2)
// 4 5 9 14 23 (n=5)

//11 -> 1+1 = 2; 1+2=3; 2+3=5
// 1 1 2 3 5 
// 3 4 7 11
/*
void Fibonacci(int count, int a, int b)
{
    int[]fibArray = new int[count];
    fibArray[0]=a;
    fibArray[1]=b;
    for (int i = 2; i < count; i++)
        fibArray[i]=fibArray[i-1]+fibArray[i-2];
    ShowArray(fibArray);
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}

Console.WriteLine("Input count of element: ");
int countOfElements = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input first element: ");
int firstEl = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second element: ");
int secondEl = Convert.ToInt32(Console.ReadLine());

Fibonacci(countOfElements,firstEl,secondEl);
*/

//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
// каждая сторона треугольника меньше суммы двух других сторон.

/*
bool Triangle(int side1, int side2, int side3)
{
    if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
        return true;
    else return false;
}

Console.WriteLine("Input first side: ");
int firstSide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second side: ");
int secondSide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third side: ");
int thirdSide = Convert.ToInt32(Console.ReadLine());

bool result = Triangle(firstSide,secondSide,thirdSide);
if(result==true)
    Console.WriteLine("Triangle exist");
else Console.WriteLine("Triangle dose not exist");
*/


//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11







string BinarSyst (int num)
{
    string binResult = string.Empty;
    while (num != 0) //не равно
    {
        binResult = num % 2 + binResult; // сначала пишет остаток от деления
        num /= 2;
    }
    return binResult;
}
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());


string result = BinarSyst(number);

Console.WriteLine($"Your number {number}  in binar syst is {result}");



// y = k1 * x + b1
// y = k2 * x + b2 <-------------             
//                              |
// k1 * x + b1 = k2 * x + b2    |
// k1 * x - k2 * x = b2 - b1    |
// x = (b2 - b1) / (k1 - k2)    |
// y = --------------------------

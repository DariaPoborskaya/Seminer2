// Задача 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

int ShowSecond(int num)
{
    int number1 = num % 100;
    int nov = number1 / 10;
    return nov;
}

int result = ShowSecond(number);
Console.WriteLine($"{number} => {result}");
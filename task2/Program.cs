// Напишите программу, которая 
// 1. выводит случайное трехзначное число
// 2. удаляет вторую цифру этого числа. 

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число - {number}");

int RemoveSecond(int num)
{
    int number1 = num / 100;
    int number2 = num % 10;
    int nov = number1 * 10 + number2;
    return nov;
}

int result = RemoveSecond(number);
Console.WriteLine($"{number} => {result}");
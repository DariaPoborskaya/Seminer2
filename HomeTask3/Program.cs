// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, 
// 2. и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNum)
{
    if (dayNum == 6 || dayNum == 7)
    {
        Console.WriteLine($"{dayNum} -> да");
    }
    else if (dayNum < 1 || dayNum > 7)
    {
        Console.WriteLine("Это не день недели, введите другое число");
    }
    else Console.WriteLine($"{dayNum} -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);
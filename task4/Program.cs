// Напишите программу, которая 
// 1. принимает на вход число и 
// 2. проверяет, кратно ли оно одновременно 7 и 23

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

bool Multip(int num, int a, int b)
{
    return num % a ==0 && num % b == 0; // возвращает true, если условие работает
}

if(Multip(number, 7, 23))
Console.WriteLine($"{number} -> Да");
else
Console.WriteLine($"{number} -> Нет");
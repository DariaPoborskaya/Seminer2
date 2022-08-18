// Напишите программу, которая
// 1. На вход принимает 2 числа и
// 2. проверяет, является ли одно число квадратом другого

Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool IsSquare(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}

if(IsSquare(number1, number2))
Console.WriteLine($"{number1}, {number2} -> Да");
else
Console.WriteLine($"{number1}, {number2} -> Нет");
// Напишите программу, которая будет 
// 1. принимать на вход два числа и 
// 2. выводить, является ли второе число кратное первому. 
// 3. Если число 2 не кратно 1, то программа выводит остаток от деления

Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
int ostatok = number1 % number2;

if(ostatok == 0)
Console.WriteLine($"{number1} кратно {number2}");
else
Console.WriteLine($"{number1} не кратно {number2} . Остаток {ostatok}");
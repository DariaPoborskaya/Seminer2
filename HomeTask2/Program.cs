// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int NumberDigit(int num) // метод поиска количества цифр в числе
{
    int count = 0;
    if (num == 0) return num;
    while (num > 0)
    {
        count++;
        num /= 10;
    }
    return count;
}

int numDig = NumberDigit(number);
Console.WriteLine($"Количество цифр введенного числа : {numDig}");

if (numDig <= 2) Console.WriteLine($"В числе {number} нет третьей цифры");

// Метод поиска последней цифры
int ShowThird(int numb)
{
   
    int numb1 = numb % 10 % 100;
    return numb1;
}

int showThird = ShowThird(number);
if (numDig > 2)
    Console.WriteLine($"В числе {number} третья цифра - {showThird}");

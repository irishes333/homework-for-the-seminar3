// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Ведите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void ShifterNumber(int num)
{
    int lastNum = num % 10;
    int firstNum = num / 10000;
    if (firstNum == lastNum)
    {
        lastNum = (num % 100) / 10;
        firstNum = (num / 1000) % 10;
        if (firstNum == lastNum) Console.WriteLine($"{num} Это число яаляетмя палиндромом");
        else Console.WriteLine($"{num} -> Нет");
    }
    else Console.WriteLine($"{num} Это число не является палиндромом");

}
ShifterNumber(number);
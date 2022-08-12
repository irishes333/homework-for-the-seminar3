// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i <= number; i++)
{
    Console.WriteLine("{0} | {1}", i, Math.Pow(i, 3));
}



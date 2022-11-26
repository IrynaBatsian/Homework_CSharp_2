// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 99 && a < 1000)
{
    int b = a / 10;
    int c = b % 10;

    Console.Write($"{c}");
}
    
else
    Console.Write("Неверно! Введите ТРЕХЗНАЧНОЕ число: ");



// Задача 13: Напишите программу, которая выводит третью цифру(c начала) заданного числа или сообщает, что третьей цифры нет.НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК.

Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 99 )
{
  while (n > 1000)
    n = n / 10;
  Console.Write($"{n % 10}");
}
else
    Console.Write("В заданном числе нет третьей цифры!");



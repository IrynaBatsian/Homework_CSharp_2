// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.Write("Введите цифру: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 1 || n == 2 || n == 3 || n == 4 || n == 5)
 Console.Write("NO");
else if (n == 6 || n == 7)
  Console.Write("YES");
else
  Console.Write("Неверно введена цифра");


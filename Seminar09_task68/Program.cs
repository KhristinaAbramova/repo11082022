﻿/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 */

Console.Clear();
int m = InputNum("Введите m: ");
int n = InputNum("Введите n: ");
int function = Ack(m, n);
Console.Write($"Результат = {function} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNum(string input) 
{
  Console.Write(input);
  int output = int.Parse(Console.ReadLine());
  return output;
}
/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


Console.Clear();
int m = InputNum("Введите m: ");
int n = InputNum("Введите n: ");
int temp = m;
if (m > n) 
{
  m = n; 
  n = temp;
}
PrintSum(m, n, temp=0);

void PrintSum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма натуральных элементов в заданном промежутке -> {sum} ");
    return;
  }
  PrintSum(m, n - 1, sum);
}

int InputNum(string input) 
{
  Console.Write(input);
  int output = int.Parse(Console.ReadLine());
  return output;
}

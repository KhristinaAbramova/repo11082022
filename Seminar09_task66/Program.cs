/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


Console.Clear();
Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());
int sum = 0;

void Summ(int M, int N, int sum)
{
    if (M == N)
    {
      sum += M;
      Console.WriteLine($" {sum}");
      return;
    }
    if (M < N)
    {
      sum += M;
      Summ(M+1, N, sum);
    }
}
sum = 0;
Console.Write($"Сумма натуральных элементов в промежутке от {M} до {N} ->  ");
Summ(M, N, sum); 
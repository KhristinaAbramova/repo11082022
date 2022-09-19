/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 */

Console.Clear();
Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());
Function(M, N);

void Function (int M, int N)
{
    Console.Write($"Решение  ->  ");
    Console.Write (Akkerman (M, N)); 
}

int Akkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return Akkerman(M - 1, 1);
    }
    else
    {
        return (Akkerman(M - 1, Akkerman(M, N - 1)));
    }
}
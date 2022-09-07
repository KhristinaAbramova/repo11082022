Console.Clear(); //очистка терминала
Console.Write("Введите колличество чисел: ");
int m = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < m; i++)
{
    Console.Write($"Число {i + 1}: ");
    int x = int.Parse(Console.ReadLine());
    if (x > 0)
        count++;
}
Console.WriteLine($"Положительные: {count}");


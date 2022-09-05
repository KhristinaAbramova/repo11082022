//Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

Console.Clear(); //очистка терминала
Console.Write("Введите размер массива: " );
int s = int.Parse(Console.ReadLine());
while (s < 0)
{
    Console.Write("Некорректный ввод повторите попытку: ");
    s = int.Parse(Console.ReadLine());
}
int count = 0;
int[] arr = new int[s];

for (int i=0; i<arr.Length; i++)
{
    arr[i]=new Random().Next(100,1000);
}

for (int i=0; i<arr.Length; i++)
{
    count+=arr[i]%2==0?1:0;
}
Console.WriteLine();
Console.WriteLine("В массиве -> " + string.Join(",",arr) + " количество четных чисел -> " + count + ".");
Console.WriteLine();

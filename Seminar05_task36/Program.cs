// Задача 36:Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.(нечетные – имеется ввиду индекс, одномерный массив – обычный) [3, 7, 23, 12] -> 19;  [-4, -6, 89, 6] -> 0.

Console.Clear(); //очистка терминала
Console.Write("Введите размер массива  ");
int s = int.Parse(Console.ReadLine());
int sum = 0;
int[] arr = new int[s];
for (int i=0; i<arr.Length; i++)
{
    arr[i]=new Random().Next(1,100);
}
for (int i=0; i<arr.Length; i++)
{
    sum += i % 2==1? arr[i] :0;
}
Console.WriteLine();
Console.WriteLine("В массиве -> " + string.Join(",",arr) + " сумма элементов стоящих на нечетных позициях индексов-> " + sum + ".");
Console.WriteLine();

